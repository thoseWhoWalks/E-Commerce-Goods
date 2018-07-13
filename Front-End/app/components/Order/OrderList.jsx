import React from 'react'; 
import {Link, BrowserRouter}  from 'react-router-dom'; 
 
 class OrderListItem extends React.Component{
 	render(){
 		return(
 				<tr>
					<td>{this.props.Product}</td>
					<td>{this.props.Anotation}</td>
				</tr>
 			);
 	}
 }


class OrderList extends React.Component{

		 constructor(props) {
               super(props); 

               this.GetTemplate = this.GetTemplate.bind(this);

               this.state = {template : ""};

               this.ProductNames = [];

                sendGetRequest("Id="+localStorage.getItem("CurrentUserId"), "http://localhost:54005/api/v1/order/getOrders", (data) => {
				   
				     if (!data.Ok) {
				         alert(data.Errors[0].Message);
				         return;
				     }

				       data.Items.map((item) => {
				     	
				     	 sendGetRequest("Id="+item.ProductId, "http://localhost:54005/api/v1/product/get", (data) => {
				  	 		
				  			this.ProductNames.push(data.Item.Title);
				  			
				  		});
				     })


				     this.setState({template:this.GetTemplate(data,this.ProductNames)});

				 });
           };
 
	  	  GetTemplate(data,ProductNames){
	  	  	
	  	    	let template;
	  	    	this.ProductNames = ProductNames;

	  	    	 template = data.Items.map( (item,index) => {
				     	return <OrderListItem Product={this.ProductNames.pop()} key ={item.Id} Anotation={item.Anotation} />
				     });

				     return template; 
	  	  }

	  render(){ 
	  	  
	  	 	return(<div className="addView " >
				    	    <h2>Order list</h2>
					  <p>Orders you've made:</p>            
					  <table className="table table-dark table-hover">
					    <thead>
					      <tr>
					        <th>Product</th>
					        <th>Notation</th>
					      </tr>
					    </thead>
					    <tbody>
					    	{this.state.template}
					    </tbody>
					  </table>

					  <div className="navButtonsSection d-flex justify-content-center">
					  		<Link to="/"><button className="btn btn-lg">Main</button></Link>
					  </div>

					</div>);
		     
   	}

}

module.exports = OrderList;
