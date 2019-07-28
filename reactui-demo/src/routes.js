import React from "react";
import { Route, Switch } from "react-router-dom";
import Login from "./Pages/Login";
import Home from "./Pages/Home";
const Routes = () => (
  <Switch>
    <Route exact path="/" component={Login} />
    <Route path="/home" component={Home} />
  </Switch>
);

export default Routes;
