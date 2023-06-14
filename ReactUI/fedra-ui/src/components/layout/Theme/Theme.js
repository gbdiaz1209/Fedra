import React from 'react'
import { useState } from 'react'; 
import { BiMoon, BiSun } from 'react-icons/bi';
import { BsSun } from 'react-icons/bs';
import { toggleTheme, getCurrenttheme } from './ConfigTheme'

export const Theme = () => {

  const [currentTheme, setCurrentTheme] = useState("");

  const handleChange = () => {    
    toggleTheme();
    let currentTheme = getCurrenttheme();
    setCurrentTheme(currentTheme);    
  };

  return (
    <>
      <div onClick={handleChange}>    
        {currentTheme == "dark" ? <BsSun size={19}/> : <BiMoon size={19} />}
      </div>
    </>
  )
}
