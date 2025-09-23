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
    <div className="flex flex-col items-center justify-center min-h-screen bg-gradient-to-br from-indigo-500 to-purple-600 p-8 space-y-12">
      <h1 className="text-4xl md:text-5xl font-extrabold text-white text-center drop-shadow-lg tracking-wide">
        Interactive Box Highlighter
      </h1>
      
      {/* Container for the color boxes */}
      <div className="flex flex-col md:flex-row space-y-6 md:space-y-0 md:space-x-12">
        <div
          ref={boxRefs[0]}
          className="w-56 h-56 rounded-3xl shadow-2xl flex items-center justify-center transform transition-all duration-500 hover:scale-105"
          style={{ backgroundColor: '#19f436ff' }} // green
        >
          <span className="text-white font-bold text-xl drop-shadow-sm">Box 1</span>
        </div>
        <div
          ref={boxRefs[1]}
          className="w-56 h-56 rounded-3xl shadow-2xl flex items-center justify-center transform transition-all duration-500 hover:scale-105"
          style={{ backgroundColor: '#120fd0ff' }} // blue
        >
          <span className="text-white font-bold text-xl drop-shadow-sm">Box 2</span>
        </div>
        <div
          ref={boxRefs[2]}
          className="w-56 h-56 rounded-3xl shadow-2xl flex items-center justify-center transform transition-all duration-500 hover:scale-105"
          style={{ backgroundColor: '#d6281bff' }} // red
        >
          <span className="text-white font-bold text-xl drop-shadow-sm">Box 3</span>
        </div>
      </div>

      
      <button
        onClick={handleHighlightNext}
        className="px-10 py-4 bg-white text-indigo-600 font-extrabold rounded-full shadow-lg transform transition-all duration-300 hover:scale-105 hover:shadow-2xl focus:outline-none focus:ring-4 focus:ring-white focus:ring-offset-2"
      >
        Highlight Next Box
      </button>
    </div>
  );
};

export default ColorBoxHighlighter;