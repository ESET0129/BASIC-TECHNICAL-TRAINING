import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';


const btnHandler=(num)=>{
  console.log(num)
}
const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <App btnClickHandler={btnHandler}/>
  </React.StrictMode>
);