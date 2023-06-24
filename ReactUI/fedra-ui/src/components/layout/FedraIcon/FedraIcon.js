import { LuMousePointer2 } from 'react-icons/lu';
import './FedraIcon.css';

export function FedraIcon() {
  return (
    <>
      <div className="d-inline-flex justify-content-center align-items-center">
        <LuMousePointer2 className='icon-rotate color-icon' size={30}/> 
        {/* <span className="divider color-icon"></span>  */}
        <div class="text-icon">Fedra</div> 
      </div>      
    </>  
  );
}
