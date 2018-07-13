import React from 'react';     
import {Link, BrowserRouter}  from 'react-router-dom';

class AccounInfo extends React.Component{

  constructor(props) { 
               super(props);  
               this.handleSubmit = this.handleSubmit.bind(this);

               ;
           };
 
  handleSubmit(e){
       e.preventDefault(); 
  }
  
  render(){return (<section className = "signUp row d-flex align-items-center">
        <div className="form text-secondary offset-lg-1 col">
                <h4 className="  title row" id="signUpTitle">Account Info</h4>
                <form onSubmit={this.handleSubmit} id="Account row">

                      <div className="form-group row">
                          <input type="text" className="form-control col-lg-8" readOnly  name="FirstName"  value={localStorage.getItem('CurrentUserEmail')} id="firstName"/>
                      </div>
 
                        <div className="row submitBtnSection"> 
                              <Link to="/logout"><button type="button" onClick={this.logout} id="logoutBtn" className="btn btn-dark btn-lg col" name="createAd">Logout</button></Link>
                        </div>
                </form>
            </div>

            <div className="signUpInfo signUpMessage col row d-flex justify-content-center">
               
                <img className="img-thumbnail" src="https://denverwebsitedesigns.com/userfiles/649/images/Homepage/thumb1.jpg" alt="img"/>
              
                <p className="message">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Provident earum error fugit aut cum, ex, eius alias maxime, iure maiores deleniti neque, sed beatae ad deserunt ullam sit vero dolore.</p>
            </div>

      </section>

    );
  }

}

module.exports = AccounInfo;
