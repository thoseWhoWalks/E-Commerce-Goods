import React from 'react';
  
class LogOut extends React.Component{

constructor(props) {
       super(props);
                
       this.handleClick = this.handleClick.bind(this)();
    };

      
 handleClick(){
      sendGetRequest($("#SignIn").serialize(), "http://localhost:54005/api/v1/user/logOut", (data) => {
           
          if(!data.Ok){
            alert(data.Errors[0].Message);
          }
          else{ 
          		if(localStorage.getItem('CurrentUser'))
	          		localStorage.removeItem('CurrentUser');
 				alert("Logged out"); 
 			}
      }); 
   }


  render(){ 
  	return (
      <div className="d-flex justify-content-center logOut"> 
        <div className="row ">
        	<img src="https://i.imgur.com/qY6Lo7w.gif" className="img-thumbnail " alt="logOut"/>
        </div>
      </div>);
  }

}

module.exports = LogOut;
