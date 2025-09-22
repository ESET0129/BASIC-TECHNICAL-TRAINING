import React, { useState, useCallback } from "react";

function Child({ onClick }) {
  console.log("Child rendered");
  return <button onClick={onClick}>Click Child Button</button>;
}

export default function UseCallbackExample() {
  const [count, setCount] = useState(0);
  const [text, setText] = useState("");

  // without useCallback -> new function is created on every render
  // with useCallback -> same function reference is reused unless `count` changes
  const handleClick = useCallback(() => {
    console.log("Child button clicked, count:", count);
  }, [count]);

  return (
    <div style={{ padding: "20px" }}>
      <h2>useCallback Example</h2>

      <button onClick={() => setCount(count + 1)}>Increment Parent Count</button>
      <p>Parent Count: {count}</p>

      <input
        type="text"
        placeholder="Type here..."
        value={text}
        onChange={(e) => setText(e.target.value)}
      />

      {/* Pass memoized callback to child */}
      <Child onClick={handleClick} />
    </div>
  );
}