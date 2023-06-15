import React from 'react'
import './NavigationBar.css'

import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';

import { BsPeople, BsBox, BsHouse } from 'react-icons/bs';
import { TbFileInvoice } from 'react-icons/tb';
import { SlNotebook } from 'react-icons/sl';
import { CgMenuGridO } from 'react-icons/cg';
import { FaAngleDown } from 'react-icons/fa';

import Theme from '../Theme';
import FedraIcon from './../FedraIcon';
import NavDropdownItems from '../NavDropdownItems';


export const NavigationBar = () => {

  return (
    <>  
      <Navbar expand="lg" fixed="top">
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
              <Nav.Link href="#action1" className="d-inline-flex align-items-center underline-padding">
                  <BsHouse size={20}/>&nbsp;&nbsp;Dashboard
              </Nav.Link>
              <Nav.Link href="#action2" className="d-inline-flex align-items-center underline-padding">
                  <BsPeople size={20} />&nbsp;&nbsp;Terceros
              </Nav.Link>             
              <Nav.Link href="#action3" className="d-inline-flex align-items-center underline-padding">
                  <BsBox size={20} />&nbsp;&nbsp;Productos
              </Nav.Link>
              <Nav.Link href="#action4" className="d-inline-flex align-items-center underline-padding">
                  <TbFileInvoice size={20} />&nbsp;&nbsp;Venta Rápida
              </Nav.Link>              
              {/* <NavDropdown title={<><CgMenuGridO size={18} />&nbsp; Documentos</>} id="navbarScrollingDropdown" className='underline-padding'>
                <NavDropdown.Item href="#action5">Factura de Venta</NavDropdown.Item>
                <NavDropdown.Item href="#action6">Compra</NavDropdown.Item>
              </NavDropdown>
              <NavDropdown title={<><SlNotebook size={18} />&nbsp; Cuentas <FaAngleDown /></>}  id="navbarScrollingDropdown2" className='underline-padding'>
                <NavDropdown.Item href="#action7">Cuentas por cobrar</NavDropdown.Item>
                <NavDropdown.Item href="#action8">Cuentas por pagar</NavDropdown.Item>
              </NavDropdown> */}
              <NavDropdownItems MenuName={"Documentos"} Icon={<CgMenuGridO  size={18} options={["compora","venta"]} />}/>
              <NavDropdownItems MenuName={"Cuentas"} Icon={<SlNotebook  size={18} />}/>
            </Nav>
            <div className="d-flex">             
            <Theme/>
            </div>
          </Navbar.Collapse>
        </Container>
      </Navbar>
    </>
  )
}
