function buttoncomponent(){
    const buttonHandler = () =>{
        console.log("hello");
      };

      return (
    <>
    <button onClick={buttonHandler}>click</button>
    <buttoncomponent></buttoncomponent>
    </>);
}

export default App;