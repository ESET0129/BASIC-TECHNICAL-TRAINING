import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import Button from './Button';


// function App() {
//   const [count, setCount] = useState(0)

//   return (
    
//     <div>
//       <h1>COUNTER</h1>
//     <h2 id='a'>0</h2>
//     <button onClick={()=>{
//       const element=document.getElementById('a');
//       var current=parseInt(element.textContent)
//       element.textContent=current+1;
//     }
//     }>
//       increment</button>
      
      
    
//     <button onClick={()=>{
//       const element=document.getElementById('a');
//       var current=parseInt(element.textContent)
//       element.textContent=current-1;
//     }
//     }>
//       decrement</button>
//       </div>

//   )
// }

// export default App

const App = () => {
  const [count, setCount] = useState(0);

  const handleIncrement = () => {
    setCount(count + 1);
    console.log('Incremented');
  };

  const handleDecrement = () => {
    setCount(count - 1);
    console.log('Decremented');
};

  const handleReset = () => {
    setCount(0);
    console.log('Reset');
  };


  return (
    <div>
      <h1>Counter</h1>
      <h2>{count}</h2>
      <Button label="Increment" onClick={handleIncrement}/>
      <Button label="Decrement" onClick={handleDecrement}/>
      <Button label="Reset" onClick={handleReset} />
    </div>
  );
};

export default App;

