import React from "react";

const dummyJson = {
    "firstName":"myname",
    "lastName":"myLastName",
    "target":{
        "value":"ddd"
    }
};

function EventComponent() {

    // console.log(dummyJson.target.value)
    const onChangeHandler = (myObject)=>{
        console.log(myObject.target.value)
    }
  return (
    <>
      Welcome to Events
      <button
        onClick={() => {
          console.log("button clicked");
        }}
      >
        click me
      </button>

      <div
       style={{
        background:'#4396d9',
        padding:'50px'
    }}
       onMouseEnter={()=>{console.log("mouse entered the div")}}
       >
        this is div
      </div>

    <input type="text" onChange={onChangeHandler} />

    </>
  );
}

export default EventComponent;