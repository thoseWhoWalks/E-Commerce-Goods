import React from 'react'; 

import {Link, BrowserRouter}  from 'react-router-dom';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';  

class ProductItem  extends React.Component{
	  render(){  
	  	return(
	  		<div className='productItem col-3' style = {{width:300}}>
			            <div className="productContainer"> 
			              <h4 className='row'>{this.props.Title}</h4>
			              <p className='row'>{this.props.Description}</p>
			              <p className='row'>{this.props.Price}</p> 
			              <Link to={`/buy/${this.props.itemId}/${this.props.Title}`}><button id='buyBtn' className='btn btn-lg'>Buy</button></Link>
			            </div>
			          </div>
	  		);
	  }
}


class ProductList extends React.Component{

		 constructor(props) {
              super(props); 
               
 			   this.state =  {template:""};
               this.generateTemplate= this.generateTemplate.bind(this);
               	

               this.data = sendGetRequest(null, "http://localhost:54005/api/v1/product/getAll", (data) =>  { 
				         this.setState({template: this.generateTemplate(data)});
				     }); 

 
           };
 
	  	   generateTemplate(data) {
			     	let template;

				    template = data.Items.map(function(item) {
				          return <ProductItem itemId={item.Id} Title={item.Title} key = {item.Id} Description = {item.Description} Price = {item.Price}/>
				     })
	 
				     return template;
				 }

	  render(){ 
	  	  
	  	 	return(<div className="ProductList container row" >
	  	 				 <div className="poductListContainer d-flex justify-content-around offset-lg-1  col-11 row">
				    	    {this.state.template}
				    	    </div>
					</div>);
		     
   	}

}

module.exports = ProductList;
