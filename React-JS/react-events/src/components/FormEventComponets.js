import { useState } from "react" 

export default function FormEvenComponents(){
const {username, setUsername} = useState("");
const {password, setPassword} = useState("");

    const onchangeHandler = (events) => {
        console.log(event.target.value)
        console.log(username)
        setUsername(event.target.value);
        console.log(password)
        setPassword(event.target.value);

        alert("this is alert box    " + username + " " + password   );//only ok button
        prompt("this is prompt box    " + username + " " + password   );//we can take input from user
        confirm("this is confirm box    " + username + " " + password   );//ok and cancel button

        console.log("Username: " + username);
        console.log("Password: " + password);
        //  setUsername(event.target.value);
        // setPassword(event.target.value); `

    }
    return(
        <div>
            <input type = 'text' value ={username} onChange ={onchangeHandler}/>
        </div>
    )
}