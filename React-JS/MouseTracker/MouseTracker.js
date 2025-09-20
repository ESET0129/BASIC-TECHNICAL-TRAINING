import React, { useState, useEffect } from 'react';
function MouseTracker() {

  const [position, setPosition] = useState({ x: 0, y: 0 });

  const handleMouseMove = (event) => {
 
    setPosition({
      x: event.clientX,
      y: event.clientY,
    });
  };

  useEffect(() => {
    
    window.addEventListener('mousemove', handleMouseMove);
    return () => {
      window.removeEventListener('mousemove', handleMouseMove);
    };

  }, []);

  return (
    <div style={{ 
        padding: '20px', 
        margin: '20px',
        border: '2px solid #7bace1ff', 
        borderRadius: '8px',
        backgroundColor: '#565657ff'
    }}>
      <h2 style={{ color: '#163c63ff' }}>Mouse Position Tracker 🧭</h2>
      <p>
        Move your cursor anywhere on the window. The coordinates are updated via a global **`mousemove`** event listener.
      </p>
      <div style={{ fontSize: '1.5em', marginTop: '15px' }}>
        <p>
          <strong>X Coordinate:</strong> <span style={{ color: 'red', fontWeight: 'bold' }}>{position.x}</span>
        </p>
        <p>
          <strong>Y Coordinate:</strong> <span style={{ color: 'green', fontWeight: 'bold' }}>{position.y}</span>
        </p>
      </div>
    </div>
  );
}

export default MouseTracker;