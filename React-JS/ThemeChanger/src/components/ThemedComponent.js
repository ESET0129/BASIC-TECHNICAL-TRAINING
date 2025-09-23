import React, { useContext } from 'react';
import { ThemeContext } from '../ThemeContext';

const ThemedComponent = () => {
  const { theme, toggleTheme } = useContext(ThemeContext);

  const style = {
    backgroundColor: theme === 'light' ? 'white' : 'black',
    color: theme === 'light' ? 'black' : 'white',
    width: '100vw',
    height: '100vh',
    display: 'flex',
    flexDirection: 'column',
    alignItems: 'center',
    justifyContent: 'center',
    transition: 'background-color 1s, color 1s',
  };

  return (
    <div style={style}>
      <h1>Theme Changer</h1>
      <h2>Current Theme: {theme}</h2>
      
      <button onClick={toggleTheme}>
         {theme === 'light' ? 'Dark' : 'Light'} Mode
      </button>
    </div>
  );
};

export default ThemedComponent;