import React from 'react';
import {Link, BrowserRouter}  from 'react-router-dom'; 
import { Router } from 'react-router';
 
class  CreateProduct extends React.Component{

  constructor(props) {
      super(props);   
      this.submit = this.submit.bind(this);  
  };
 
  submit(e){ 
         e.preventDefault(); 

        if($("#title").val().length==0)
        {
          alert("Fields is empty");
          return;
        } 

        sendPostRequest($("#createProducts").serialize(), "http://localhost:54005/api/v1/product/create", function(data) {
          alert("Done: " + data.Item.Title);
          
        });

        this.props.history.push('/')
          
  };

   
  render(){  
      return( 
        <section className="col-lg-8 offset-lg-2 createAddSection">
          <form id="createProducts" >
            <div className="form-group ">
              <label  className="row">Title:</label>
                <input type="text" required name="Title" placeholder="Enter title please" className="form-control row" id="title"/>
              </div>
              <div className ="form-group" >
                <label htmlFor="desc" className="row">Description:</label>
                <textarea className="form-control row" name="Description" required rows="5" id="desc"></textarea>
              </div> 
               <div className ="form-group" >
                <label htmlFor="price" className="row">Price:</label>
                <input type="number" className="form-control row" name="Price" required id="price"/>
              </div> 
            
           <div className="d-flex justify-content-center navigationBtnSection">
                <button className="btn-lg btn-default" onClick={this.submit}>Create</button> 
                <Link to="/"><button className="btn-lg btn-default ">Main</button></Link> 
              </div>

          </form>
        </section>); 
  }
}

module.exports = CreateProduct;
