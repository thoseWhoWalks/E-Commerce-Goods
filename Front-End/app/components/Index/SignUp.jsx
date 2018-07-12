import React from 'react'; 
import { Redirect } from 'react-router';
import {Link, BrowserRouter}  from 'react-router-dom';   
import { Router } from 'react-router';
import $ from 'jquery';

class SignIn extends React.Component{

  constructor(props) {
       super(props);
                
       this.submit = this.submit.bind(this);  
    };
 
  submit(e){
   
    if($("#firstName").val().length == 0 || $("#password").val().length == 0){
       alert("Fields are empty");
       return;
     }

       e.preventDefault(); 
 
      sendPostRequest($("#SignUp").serialize(), "http://localhost:54005/api/v1/user/signUp", (data) => {

        if(data.Errors.length==0){
          alert("Signed up...");
            this.props.history.push('/');
        }
        else
          alert(data.Errors[0].Message);

      }); 
   }

  render(){return (<section className = "signUp row">
        <div className="form text-secondary offset-lg-1 col">
                <h4 className="  title row" id="signUpTitle">Sign Up</h4>
                <form id="SignUp">

                      <div className="form-group row">
                          <input type="email" className="form-control col-lg-8" required name="Email"     placeholder="Email" defaultValue="admin@admin" id="Email"/>
                      </div>

                      <div className="form-group row">
                          <input type="text" className="form-control col-lg-8" required name="FirstName"  placeholder="Admin" defaultValue="First Name" id="firstName"/>
                      </div>

                      <div className="form-group row">
                          <input type="text" className="form-control col-lg-8" required name="LastName"     placeholder="Last Name" defaultValue="Admin" id="LirstName"/>
                      </div>

                       <div className="form-group  row">
                            <input type="password" className="form-control col-lg-8" name="Password" pattern=".{6,}" required placeholder="Password" defaultValue="123456" id="password"/>
                        </div>

                        <div className="row submitBtnSection">
                              <button id="submitBtn" onClick={this.submit} className="btn btn-dark btn-lg ">Sign Up</button> 
                              

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
