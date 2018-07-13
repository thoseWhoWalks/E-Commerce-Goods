import React from 'react'; 
import { Redirect } from 'react-router';
import {Link, BrowserRouter}  from 'react-router-dom';  
import SignIn from './SignIn.jsx'; 
import AccountInfo from './AccountInfo.jsx';
import ProductList from '../Product/ProductList.jsx';

class Index extends React.Component{

  render(){ 
  		 

 		if(localStorage.getItem('CurrentUserId')==undefined){ 
 			return (
 				<div> 
			        <SignIn history={this.props.history}></SignIn>
			    </div>);
 		}
 		else{ 
  		 return (<div> 
  		 			 <AccountInfo></AccountInfo>
  		 			 <ProductList/>
  		 			 <div className="d-flex justify-content-center createProductBtnSection">
                                
                               <Link to="/createProduct"><button  className="btn btn-dark btn-lg ">Create Product</button></Link>
								<Link to="/OrderList"><button  className="btn btn-dark btn-lg ">Orders history</button></Link>

                        </div>
			    </div>);
 		} 
  } 
}

module.exports = Index;
