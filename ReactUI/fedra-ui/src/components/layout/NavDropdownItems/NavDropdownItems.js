import { useState } from 'react';
import { NavDropdown } from 'react-bootstrap';
import { FaAngleDown, FaAngleUp } from 'react-icons/fa';

import './NavDropdownItems.css';
export function NavDropdownItems({ MenuName, Icon, options}) {
  const [open, setOpen] = useState(false);

  const handleToggle = () => setOpen(!open);

  return (
    <NavDropdown title={<CustomToggle />} id="basic-nav-dropdown" onToggle={handleToggle}>
      {options.forEach(element => {
         <NavDropdown.Item href="#action/3.1">{element}</NavDropdown.Item>
      })}
    </NavDropdown>
  );

  function CustomToggle() {
    return (
      <div>
        {Icon} {MenuName} &nbsp;
        {open ? <FaAngleUp size={19} /> : <FaAngleDown size={19} />}
      </div>
    );
  }
}