import React from 'react';
import {Link, BrowserRouter}  from 'react-router-dom';  
 
class  CreateOrder extends React.Component{

  constructor(props) {
      super(props);   
      this.submit = this.submit.bind(this); 
       
      let uri = this.props.location.pathname;
      const regex = new RegExp(".*buy\/(?<one>.*)\/(?<two>.*)","gm");
 
       this.state = {matches: regex.exec(uri)}; 
       
  };
 
  submit(e){ 
      e.preventDefault(); 
  
        sendPostRequest($("#createOrder").serialize(), "http://localhost:54005/api/v1/order/create", function(data) {
          alert("Done: " + data.Item[0].Title); 
        });

        setTimeout(this.props.history.push('/'),5000);
          
  };

  
  render(){ 
  
      return( 
        <section className="col-lg-8 offset-lg-2 createAddSection">
          <form id="createOrder"  >
            <div className="form-group ">
              <label   className="row"><h2>Product: {this.state.matches[2]}</h2></label>
                <input type="hidden"  name="ProductId" value={this.state.matches[1]} className="form-control row" value/>
              </div>
              <div className ="form-group" >
                <label htmlFor="desc" className="row">Notation:</label>
                <textarea className="form-control row" name="Anotation" rows="5" id="desc"></textarea>
              </div> 
               <div className ="form-group" >
                <input type="hidden" className="form-control row" name="UserId" required value={localStorage.getItem("CurrentUserId")}/>
              </div> 
            <div className="d-flex justify-content-center navigationBtnSection">
                <button className="btn-lg btn-default" onClick={this.submit}>Create</button> 
                <Link to="/"><button className="btn-lg btn-default ">Main</button></Link> 
              </div>
          </form>
        </section>); 
  }
}

module.exports = CreateOrder;
