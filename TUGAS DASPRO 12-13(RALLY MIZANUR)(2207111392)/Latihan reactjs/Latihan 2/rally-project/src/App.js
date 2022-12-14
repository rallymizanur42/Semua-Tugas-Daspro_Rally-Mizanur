import React, {Component} from 'react';
import { BrowserRouter as Router, Route, Link, Routes } from "react-router-dom";
import logo from './logo-unri.webp';
import './App.css';
import User from "./components/User";
import Blog from "./components/Blog";
import Account from "./components/Account";


class App extends Component {
  render() {
    return (
      <Router>
        <div>
          <Link to="/">Home| </Link>
          <Link to="/Account">Account| </Link>
          <Link to="/Blog">Blog| </Link>
          <hr />
          <img src={logo} className="App-logo" alt="logo" />
          <Routes>
            <Route exact path="/" element={<User/>} />
            <Route path="account" element={<Account/>} />
            <Route path="blog" element={<Blog/>} />
          </Routes>
        </div>
      </Router>
    );
  }
}

export default App;
