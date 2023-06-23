import React, { useState } from 'react'

import Dropdown from 'react-bootstrap/Dropdown';
import { NavDropdown } from 'react-bootstrap';

import { FaAngleDown } from 'react-icons/fa';
import { 
  FcDocument, FcReadingEbook,
  FcExport, FcMoneyTransfer,
  FcRules, FcRight, FcLeft,
  FcImport, FcBriefcase, FcFolder } from 'react-icons/fc';


import './MegaMenu.css';

export function MegaMenu( props ) {

  const 
  { 
     icon,
     menuName,
     id
  } = props;

  const [show, setShow] = useState(false);

  function CustomToggle() {
    return (
      <div className={show ? "text-primary" : ""}>
        {icon} {menuName} {" "} <FaAngleDown size={17} />
      </div>
    );
  }

  return (
    <NavDropdown 
      title={<CustomToggle />} 
      id={id}                  
      onMouseEnter={() => setShow(true)}
      onMouseLeave={() => setShow(false)}         
      className='d-inline-flex align-items-center'
      renderMenuOnMount={true}>
        <div className='container py-3'>
            <div className="dropdown-mega-menu d-flex flex-row  fade-in">
          <div className="col-lg-7 col-sm-12">
              <div className="menu-principal">
                <Dropdown.Item className='rounded py-2'>
                   <div className=" d-flex  ">
                    <FcDocument size={30} className="me-3 object-fit-contain border-0 rounded" /> 
                    <div className=" ">
                      <label className='submenu-item align-top'>
                        <label className='titulo-item'>Facturas</label> 
                        <br />
                        <small>Gestiona las ventas</small></label>
                    </div>                    
                  </div>
                </Dropdown.Item>
                <Dropdown.Item className='rounded py-2'>
                   <div className=" d-flex  ">
                    <FcReadingEbook size={30} className="me-3 object-fit-contain border-0 rounded" /> 
                    <div className=" ">
                      <label className='submenu-item align-top'>
                      <label className='titulo-item'>Compras</label> 
                        <br />
                      <small>Compras a proveedores</small></label>
                    </div>                    
                  </div>
                </Dropdown.Item>
                <Dropdown.Item className='rounded py-2'>
                   <div className=" d-flex  ">
                    <FcExport size={30} className="me-3 object-fit-contain border-0 rounded" /> 
                    <div className=" ">
                      <label className='submenu-item align-top'>
                      <label className='titulo-item'>Comprobante de egreso</label> 
                         <br />
                      <small>Controla los gastos</small></label>
                    </div>                    
                  </div>
                </Dropdown.Item>
                <Dropdown.Item className='rounded py-2'>
                   <div className=" d-flex  ">
                    <FcMoneyTransfer size={30} className="me-3 object-fit-contain border-0 rounded" /> 
                    <div className=" ">
                      <label className='submenu-item align-top'>
                      <label className='titulo-item'>Recibo de caja</label> 
                        <br />
                      <small>Historial de recibos</small></label>
                    </div>                    
                  </div>
                </Dropdown.Item>
                <Dropdown.Item className='rounded py-2'>
                   <div className=" d-flex  ">
                    <FcRules size={30} className="me-3 object-fit-contain border-0 rounded" /> 
                    <div className=" ">
                      <label className='submenu-item align-top'>
                      <label className='titulo-item'>Cotización</label> 
                      <br />
                      <small>Gestiona las cotizaciones</small></label>
                    </div>                    
                  </div>
                </Dropdown.Item>
              </div>              
          </div>
          
          <div className="col-lg-5 col-sm-12">
           
            <div class="d-flex py-3 px-3 titulo-otros">
              Otros          
            </div>
            <Dropdown.Item className='rounded'>
              <div class="d-flex justify-content-between ">
                <div className='px-3 submenu-item'>Comprobante de ingreso</div>              
                <FcImport  size={25}/>
              </div>
            </Dropdown.Item>
            <Dropdown.Item className='rounded'>
              <div class="d-flex justify-content-between ">
                <div className='px-3 submenu-item'>Devolución en venta</div>              
                <FcBriefcase  size={25}/>
              </div>
            </Dropdown.Item>          
            <Dropdown.Item className='rounded'>
              <div class="d-flex justify-content-between ">
                <div className='px-3 submenu-item'>Devolución en compra</div>              
                <FcFolder  size={25}/>
              </div>
            </Dropdown.Item>            
            <Dropdown.Item className='rounded'>
              <div class="d-flex justify-content-between ">
                <div className='px-3 submenu-item'>Entrada Inventario</div>              
                <FcLeft  size={25}/>
              </div>
            </Dropdown.Item> 
            <Dropdown.Item className='rounded'>
              <div class="d-flex justify-content-between ">
                <div className='px-3 submenu-item'>Salida Inventario</div>              
                <FcRight   size={25}/>
              </div>
            </Dropdown.Item> 
          </div>
        </div>
        </div>
    </NavDropdown>
  );

 
}

