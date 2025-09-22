import React from "react";
import { createContext, useState } from "react";
import UseContextSample from "./components1/UseContextSample";

const Context = createContext();

export {Context}
function App(){
  console.log(React)
  const [count,setCount]=useState(0);
  const [username,setUsername]=useState("username");
  return(
    <Context.Provider value={{
      count:count,
      setCount:setCount,
      username,
      setUsername}} >
      <UseContextSample/>
    </Context.Provider>
  )
}

export default App;