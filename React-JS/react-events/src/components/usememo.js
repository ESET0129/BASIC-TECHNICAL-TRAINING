import React,{useState,useMemo} from 'react'

export default function UseMemoSample() {
    const [count, setCount] = useState(0);
    const [text, setText] = useState("");

  // Expensive calculation
    const expensiveCalculation = (num) => {
        console.log("Running expensive calculation...");
        for (let i = 0; i < 1000000000; i++) {} // simulate heavy work
        return num * 2;
    };    
  const memoizedValue = useMemo(() => expensiveCalculation(count), [count]);


  return (
    <div>
       <div style={{ padding: "20px" }}>
      <h2>useMemo Example</h2>

      <div>
        <button onClick={() => setCount(count + 1)}>Increment Count</button>
        <p>Count: {count}</p>
        <p>Expensive Result: {memoizedValue}</p>
      </div>

      <div>
        <input
          type="text"
          placeholder="Type something..."
          value={text}
          onChange={(e) => setText(e.target.value)}
        />
        <p>Text: {text}</p>
      </div>
    </div>
    </div>
  )
}