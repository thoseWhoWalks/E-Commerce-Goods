import ReactDOM from 'react-dom';
import React from 'react';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom'; 
import Index from './components/Index/Index.jsx';
import OrderList from './components/Order/OrderList.jsx';
import Logout from './components/Logout/Logout.jsx'; 
import SignUp from './components/Index/SignUp.jsx';
import CreateOrder from "./components/Order/CreateOrder.jsx";
import CreateProduct from "./components/Product/CreateProduct.jsx";

ReactDOM.render(
    <Router>
        <Switch>
            <Route exact path="/" component={Index} />
            <Route   path="/logout" component={Logout} />   
            <Route path ="/signUp" component={SignUp} />
            <Route path = "/buy/:id/:productName" component={CreateOrder}/>
            <Route path = "/createProduct" component={CreateProduct}/>
            <Route path = "/orderList" component={OrderList}/>
        </Switch>
    </Router>,
    document.querySelector("main")
)
