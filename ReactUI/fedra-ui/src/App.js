import './App.css';
import TopNav from './components/TopNav';
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
      <TopNav />
      {/* SideNAvigation */}
      {/* Dashboard */}
    </div>
  );
}

export default App;
