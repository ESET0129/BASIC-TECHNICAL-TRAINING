import React, { useState } from 'react'

function LoginComponent() {


    const [username,setUsername] = useState("")
    const [password,setPassword] = useState("")

    const onLoginHandler = ()=>{
        if(username!=="username"){
            alert("invalid username")
            return;
        }
        if(password!=="password"){
            alert("invalid password")
            return;
        }
        alert("login successfull")
    }

  return (
    <div>
      <input type='text' value={username}  onChange={(e)=>{setUsername(e.target.value)}} placeholder='enter your username'/>
      <input type='password' value={password}  onChange={(e)=>{setPassword(e.target.value)}} placeholder='enter your password'/>
      <button onClick={onLoginHandler}>login</button>
    </div>
  )
}

export default LoginComponent