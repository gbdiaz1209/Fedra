import React from 'react'
import { THEME, toggleTheme, setTheme, resetTheme } from './ConfigTheme'

export const Theme = () => {
  return (
    <>
      <button onClick={() => toggleTheme()}>
        Toggle Theme
      </button>
      <button onClick={() => setTheme(THEME.LIGHT)}>
        Light Theme
      </button>
      <button onClick={() => setTheme(THEME.DARK)}>
        Dark Theme
      </button>
      <button onClick={() => setTheme(THEME.BLUE)}>
        Blue Theme
      </button>
      <button onClick={() => resetTheme()}>
        Auto Theme
      </button>
    </>
  )
}
