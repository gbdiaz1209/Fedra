import { initTheme } from './components/layout/Theme/ConfigTheme';
import { AppScreen } from './components/app/AppScreen';

initTheme()

function App() {
  return (
    <div className="App" >                            
      {/* TopNavigation */}
      {/* <TopNav /> */}
      {/* SideNAvigation */}
      {/* Dashboard */}
      <AppScreen />
    </div>
  );
}

export default App;
