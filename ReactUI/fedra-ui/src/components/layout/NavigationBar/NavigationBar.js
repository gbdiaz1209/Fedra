import React, { useEffect, useState } from 'react'
import './NavigationBar.css'

import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';

import { BsPeople, BsBox, BsHouse } from 'react-icons/bs';
import { TbFileInvoice } from 'react-icons/tb';
import { SlNotebook } from 'react-icons/sl';
import { CgMenuGridO } from 'react-icons/cg';
import { FaAngleDown } from 'react-icons/fa';
import { BiMoon, BiSun } from 'react-icons/bi';
import { BsSun } from 'react-icons/bs';
import FedraIcon from './../FedraIcon';
import MegaMenu from '../MegaMenu';
import { toggleTheme, getCurrenttheme } from './../Theme/ConfigTheme';

export const NavigationBar = () => {
  
  const [currentTheme, setCurrentTheme] = useState("");
  const [scrolled, setScrolled] = useState(false);

  const handleScroll = () => {
    const offset = window.scrollY;
    if (offset > 100) {      
      setScrolled(true);
    } else {
      setScrolled(false);
    }
  };
  
  window.addEventListener('scroll', handleScroll);

  useEffect(() => {
    if(currentTheme === ""){
      let currentTheme = getCurrenttheme();
      setCurrentTheme(currentTheme);  
    }
  }, [currentTheme])

  const handleChange = () => {    
    toggleTheme();
    let currentTheme = getCurrenttheme();
    setCurrentTheme(currentTheme);    
  };

  return (
    <>  
      <Navbar expand="lg" fixed="top" className={scrolled ? 'navbar-abajo' : ''}  bg={currentTheme}>
        <Container fluid>
          <Navbar.Brand href="#" className="d-inline-flex justify-content-center align-items-center" >   
            <FedraIcon /> 
          </Navbar.Brand>
          <Navbar.Toggle aria-controls="navbarScroll" />
          <Navbar.Collapse id="navbarScroll" className='center'>
            <Nav
             className="justify-content-center flex-grow-1 pe-5 small gap-2"
              style={{ maxHeight: '400px' }}
              navbarScroll
            >  
              <Nav.Link href="#action1" className="d-inline-flex align-items-center menu-hover">
                  <BsHouse size={20}/>&nbsp;&nbsp;Dashboard
              </Nav.Link>
              <Nav.Link href="#action4" className="d-inline-flex align-items-center menu-hover">
                  <TbFileInvoice size={20} />&nbsp;&nbsp;Venta Rápida
              </Nav.Link> 
              <MegaMenu 
                id={"documentos-dropdown"} 
                menuName={"Documentos"}                                 
                icon={<CgMenuGridO  size={20}/>}
               
              />
              <Nav.Link href="#action2" className="d-inline-flex align-items-center menu-hover">
                  <BsPeople size={20} />&nbsp;&nbsp;Terceros
              </Nav.Link>             
              <Nav.Link href="#action3" className="d-inline-flex align-items-center menu-hover">
                  <BsBox size={20} />&nbsp;&nbsp;Productos
              </Nav.Link>
                           
              {/* <NavDropdown title={<><CgMenuGridO size={18} />&nbsp; Documentos</>} id="navbarScrollingDropdown" className='underline-padding'>
                <NavDropdown.Item href="#action5">Factura de Venta</NavDropdown.Item>
                <NavDropdown.Item href="#action6">Compra</NavDropdown.Item>
              </NavDropdown>
              <NavDropdown title={<><SlNotebook size={18} />&nbsp; Cuentas <FaAngleDown /></>}  id="navbarScrollingDropdown2" className='underline-padding'>
                <NavDropdown.Item href="#action7">Cuentas por cobrar</NavDropdown.Item>
                <NavDropdown.Item href="#action8">Cuentas por pagar</NavDropdown.Item>
              </NavDropdown> */}
            </Nav>
            <div className="d-flex">             
              <div onClick={handleChange}>    
                {currentTheme == "dark" ? <BsSun size={19}/> : <BiMoon size={19} />}
              </div>
            </div>
          </Navbar.Collapse>
        </Container>
      </Navbar>
      <div style={{ paddingTop: '50px' }}></div>
    </>
  )
}
