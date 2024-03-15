// import React, { useEffect } from 'react';
// import { useState } from 'react';
import React from 'react';
import logo from './logo.svg';
import './App.css';
import BowlerList from './BowlerList';
import Header from './Header';
import 'bootstrap/dist/css/bootstrap.min.css';
//import data

function App() {
  return (
    <div className="App">
      <Header/>
      <br/>
      <br/>
      <BowlerList/>
    </div>
  );
}

export default App;
