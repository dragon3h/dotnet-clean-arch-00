import React, { Component } from "react";
import "./App.css";
import { BrowserRouter, Switch, Route } from "react-router-dom";

import Layout from "../components/Layout/Layout";
import Home from "../components/Home/Home";
import OwnerList from "./Owner/OwnerList/OwnerList";

class App extends Component {
  render() {
    return (
      <BrowserRouter>
        <Layout>
          <Switch>
            <Route path="/" exact component={Home} />
            <Route path="/owner-list" component={OwnerList} />
          </Switch>
        </Layout>
      </BrowserRouter>
    );
  }
}

export default App;
