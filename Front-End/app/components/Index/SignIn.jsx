import React from 'react'; 
import { Redirect } from 'react-router';
import {Link, BrowserRouter, Router}  from 'react-router-dom';   
import $ from 'jquery';
import "../dataWorker.js"; 
import Cookies from 'universal-cookie';


class SignIn extends React.Component{

  constructor(props) {
       super(props);
                
       this.submit = this.submit.bind(this); 
       this.handleSubmit = this.handleSubmit.bind(this);
    };
 
  submit(e){
   
    e.preventDefault(); 
 
    if($("#Email").val().length == 0 || $("#Password").val().length == 0){
       alert("Fields are empty");
       return;
     } 
     
      sendPostRequest($("#SignIn").serialize(), "http://localhost:54005/api/v1/user/signIn",  (data,xhr,some) => {
            
          if(!data.Ok){
            alert(data.Errors[0].Message);
          }
          else{
            alert("Logged in...");
            localStorage.setItem('CurrentUser', data.Item.Id); 
          }
 
      });

   }

   handleSubmit(e) {

    }
 

  render(){return (<section className = "signUp row">
        <div className="form text-secondary offset-lg-1 col">
                <h4 className="  title row" id="signUpTitle">Sign In</h4>
                <form onSubmit={this.handleSubmit} id="SignIn">

                      <div className="form-group row">
                          <input type="text" className="form-control col-lg-8" required name="Email" autoComplete="given-name" pattern="[a-zA-Z]+" placeholder="User name" defaultValue="admin" id="Email"/>
                      </div>

                       <div className="form-group  row">
                            <input type="password" className="form-control col-lg-8" name="Password" pattern=".{6,}" required placeholder="Password" defaultValue="123456" id="Password"/>
                        </div>

                        <div className="row submitBtnSection">
                              <button id="submitBtn" onClick={this.submit} className="btn btn-dark btn-lg ">Sign In</button> 
                             <Link to="/signUp"><button id="signUpBtn"  className="btn btn-dark btn-lg ">Sign Up</button></Link>
                        </div>

                         
                </form>
            </div>

            <div className="signUpInfo signUpMessage col row d-flex justify-content-center">
               
                <img className="img-thumbnail" src="https://denverwebsitedesigns.com/userfiles/649/images/Homepage/thumb1.jpg" alt="img"/>
              
                <p className="message">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Provident earum error fugit aut cum, ex, eius alias maxime, iure maiores deleniti neque, sed beatae ad deserunt ullam sit vero dolore.</p>
            </div>

      </section>);
  }
}

module.exports = SignIn;
