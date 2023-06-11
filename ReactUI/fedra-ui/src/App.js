import './App.css';
import NavigationBar from './components/NavigationBar';
import { THEME, initTheme, toggleTheme, setTheme, resetTheme } from './Theme'

initTheme()

function App() {
  return (
    <div className="App" >
                            <button onClick={() => toggleTheme()}>
                            Toggle Theme
                          </button>
                          <button onClick={() => setTheme(THEME.LIGHT)}>
                            Light Theme
                          </button>
                          <button onClick={() => setTheme(THEME.DARK)}>
                            Dark Theme
                          </button>
                          <button onClick={() => resetTheme()}>
                            Auto Theme
                          </button>
      {/* TopNavigation */}
      {/* <TopNav /> */}
      {/* SideNAvigation */}
      {/* Dashboard */}
      <NavigationBar />
    </div>
  );
}

export default App;
