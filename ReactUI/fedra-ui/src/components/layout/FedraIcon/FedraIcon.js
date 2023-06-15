import { DiUikit } from 'react-icons/di';
import { IconContext } from 'react-icons';
import './FedraIcon.css';


export function FedraIcon() {
  return (
    <IconContext.Provider 
        value={{ className: 'flex justify-content-center   circle-icon-size' }}>        
      <div>
        <DiUikit />fedra
      </div>
    </IconContext.Provider>
  );
}
