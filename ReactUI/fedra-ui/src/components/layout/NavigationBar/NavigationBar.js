import React from 'react'
import './NavigationBar.css'
//using normales
import Button from 'react-bootstrap/Button';
import Container from 'react-bootstrap/Container';
import Form from 'react-bootstrap/Form';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';

import { BsPeople, BsBox, BsHouse } from 'react-icons/bs';
import { TbFileInvoice } from 'react-icons/tb';
import { SlNotebook } from 'react-icons/sl';
import { CgMenuGridO } from 'react-icons/cg';


import { Badge  } from 'react-bootstrap';
import Theme from '../Theme';


export const NavigationBar = () => {

  return (
    <>  
      <Navbar expand="lg" fixed="top">
        <Container fluid>
          <Navbar.Brand href="#" className=" d-inline-flex" >
            <Badge bg="primary" 
                   className="rounded-circle d-inline-flex justify-content-center align-items-center fs-4" 
                   style={{ width: '30px', height: '30px' }}>
                    F
            </Badge>
            edra</Navbar.Brand>
          <Navbar.Toggle aria-controls="navbarScroll" />
          <Navbar.Collapse id="navbarScroll" className='center'>
            <Nav
             className="justify-content-center flex-grow-1 pe-5 small gap-2"
              style={{ maxHeight: '400px' }}
              navbarScroll
            >  

              <Nav.Link href="#action1" className="d-inline-flex align-items-center">
                  <BsHouse size={20}/>&nbsp;&nbsp;Dashboard
              </Nav.Link>
              <Nav.Link href="#action1" className="d-inline-flex align-items-center">
                  <BsPeople size={20} />&nbsp;&nbsp;Terceros
              </Nav.Link>             
              <Nav.Link href="#action1" className="d-inline-flex align-items-center">
                  <BsBox size={20} />&nbsp;&nbsp;Productos
              </Nav.Link>
              <Nav.Link href="#action1" className="d-inline-flex align-items-center">
                  <TbFileInvoice size={20} />&nbsp;&nbsp;Venta Rápida
              </Nav.Link>              
              <NavDropdown title={<><CgMenuGridO size={18} />&nbsp; Documentos</>} id="navbarScrollingDropdown">
                <NavDropdown.Item href="#action3">Factura de Venta</NavDropdown.Item>
                <NavDropdown.Item href="#action3">Compra</NavDropdown.Item>
              </NavDropdown>
              <NavDropdown title={<><SlNotebook size={18} />&nbsp; Cuentas</>} id="navbarScrollingDropdown">
              <NavDropdown.Item href="#action3">Cuentas por cobrar</NavDropdown.Item>
                <NavDropdown.Item href="#action3">Cuentas por pagar</NavDropdown.Item>
              </NavDropdown>
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
