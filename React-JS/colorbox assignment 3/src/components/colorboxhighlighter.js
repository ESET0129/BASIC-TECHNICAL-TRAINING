import React, { useRef, useState } from 'react';

const ColorBoxHighlighter = () => {
  
  const boxRefs = [useRef(null), useRef(null), useRef(null)];
  
  
  const [highlightedIndex, setHighlightedIndex] = useState(-1);

  
  const handleHighlightNext = () => {
   
    if (highlightedIndex !== -1 && boxRefs[highlightedIndex].current) {
      boxRefs[highlightedIndex].current.style.border = 'none';
    }

    
    const nextIndex = (highlightedIndex + 1) % boxRefs.length;

    
    if (boxRefs[nextIndex].current) {
      boxRefs[nextIndex].current.style.border = '4px solid #6366f1'; 
      boxRefs[nextIndex].current.style.boxShadow = '0 0 20px #6366f1';
    }

    
    setHighlightedIndex(nextIndex);
  };

  return (
    <div className=" ">
      <h1 className=" ">
        Interactive Box Highlighter
      </h1>
      
      
      <div className=" flex space-x-8 my-8">
        <div
          ref={boxRefs[0]}
          className="  "
          style={{ backgroundColor: '#19f436ff' }} // green
        >
          <span className=" ">Box 1</span>
        </div>
        <div
          ref={boxRefs[1]}
          className=" "
          style={{ backgroundColor: '#120fd0ff' }} // blue
        >
          <span className="  ">Box 2</span>
        </div>
        <div
          ref={boxRefs[2]}
          className=" "
          style={{ backgroundColor: '#d6281bff' }} // red
        >
          <span className=" ">Box 3</span>
        </div>
      </div>

      
      <button
        onClick={handleHighlightNext}
        className=" "
      >
        Highlight Next Box
      </button>
    </div>
  );
};

export default ColorBoxHighlighter;
