// import logo from './logo.svg';
// import './App.css';
import UseStateComponent from "./components/usestatecomponent.js";
import buttoncomponent from "./src/buttoncomponent.js";
import React from "react";
import useeffectcomponent from "./components/useeffectcomponent.js";
import FormEvenComponents from "./components/FormEventComponets.js";
import Loginform from "./components/loginformcomponent.js";
/*
function MouseEvent() {
     const buttonHandler = () =>{
        console.log("hello");
      };

  return (
    <>
    <button onClick={buttonHandler}>click</button>
    <buttoncomponent/>
    </>
    //<div className="App">{
       <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        { <p>
          Edit <code>src/App.js</code> and save to reload.
        </p> }
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header> 
   
    //}</div>
  );
}
*/

function MouseEvent(){
  return(
    <>
    </>
  )
}

<UseStateComponent>
  <div>

  </div>

</UseStateComponent>

<useeffectcomponent></useeffectcomponent>

<FormEvenComponents></FormEvenComponents>
<Loginform></Loginform> 

export default App;
