import React, { useEffect, useState } from 'react'
import './TopNav.css'

import { BsPeople, BsBox, BsHouse } from 'react-icons/bs';
import { TbFileInvoice, TbReportMoney } from 'react-icons/tb';
import { CgMenuGridO } from 'react-icons/cg';
import { BiMoon } from 'react-icons/bi';
import { BsSun } from 'react-icons/bs';

import { getCurrenttheme, toggleTheme } from '../Theme/ConfigTheme';
import FedraIcon from '../FedraIcon';

export const TopNav = () => {
  
  const [currentTheme, setCurrentTheme] = useState("");
  const [showMenuCelular, setShowMenuCelular] = useState(false);
  
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
    
    ajustarScrollEvitarTopNavTransparente();
  };

  const abrirMenuCelular = () => {
    setShowMenuCelular(true);    
  }

  const cerrarMenuCelular = () => {
    ajustarScrollEvitarTopNavTransparente();
    setShowMenuCelular(false);    
  }

  const ajustarScrollEvitarTopNavTransparente = () => {
    window.scrollTo(0, window.scrollY*0.99);
  }

  return (
    <>
    <header className={`header-of-page bd-gutter 
                        ${currentTheme==="dark"  ? "border-navbar-dark" : ""} 
                        ${showMenuCelular ? "show-phone-menu" : ""}`
    }>
          <div className="header-content">
              <div className="left-logo">
              <FedraIcon />     
          </div>        
          <div className="header-nav">
            <div className="nav-item">
              <a href="#" className="first-nav">
                <BsHouse size={18}/>&nbsp;&nbsp;Dashboard          
              </a>
            </div>   

            <div className="nav-item">
              <a href="https://www.mockplus.com/enterprise" className="first-nav">
                <TbFileInvoice size={18} />&nbsp;&nbsp;Venta Rápida
              </a>
            </div>

            <div className="nav-item">
              <span className="first-nav">
                  <CgMenuGridO size={18} />&nbsp;&nbsp;Documentos        
                  <i className="iconfont icon_broad_back" />
              </span>
              <div className="second-menu">
                <div className="left-list">
                  <div className="top-titles">Principales</div>
                  <a
                    href="#"
                    style={{ backgroundImage: 'url("../images/nav/pic1.png")' }}
                  >
                    
                    <span>Facturas</span>
                    <p>Gestiona las ventas</p>
                  </a>
                  <a
                    href="#"
                    style={{ backgroundImage: 'url("../images/nav/compras.png")' }}
                  >
                    <span>Compras</span>
                    <p>Gestion de compras a proveedores</p>
                  </a>
                  <a
                    href="#"
                    style={{ backgroundImage: 'url("../images/nav/ce.avif")' }}
                  >
                    <span>Comprobante de Egreso</span>
                    <p>Controla los gastos del negocio</p>
                  </a>
                  <a
                    style={{ backgroundImage: 'url("../images/nav/rcaja.png")' }}
                    id="head-nav-download-rp"
                  >
                    <span>Recibo d Caja</span>
                    <p>Historial de recibos</p>
                  </a>
                  <div className="top-titles-line">
                    Necesitas una cotización de venta？
                  </div>
                  <a
                    href="#"
                    style={{ backgroundImage: 'url("../images/nav/help-call.png")' }}
                  >
                    <span>Cotizaciones</span>
                    <p>Genera cotizaciones rapidamente</p>
                  </a>
                </div>
                <div className="line" />
                <div className="right-cons">
                  <div className="top-titles">
                    Otros              
                  </div>
                  <a href="#" className="a1">
                    Comprobantre de Ingreso
                  </a>
                  <a href="#" className="a1">
                    Devolucion en venta
                  </a>
                  <a href="#" className="a1">
                    Devolucion en Compra
                  </a>           
                  <div className="top-titles">Ajuste de inventario</div>
                  <a href="#" className="a1">
                    Entrada de Inventario
                  </a>
                  <a
                    href="#"
                    className="a1"
                  >
                    Salida de Inventario
                  </a>
                  <a href="@" className="a1">
                    Inventario Inicial
                  </a>           
                  <div className="top-titles">Ajustes</div>
                  <a
                    href="#"
                    className="a1"
                  >
                    Configuración de documentos{" "}
                  </a>
                </div>
              </div>
            </div>  

            <div className="nav-item">
              <span className="first-nav">
                <TbReportMoney size={18} />&nbsp;&nbsp;Cuentas
                <i className="iconfont icon_broad_back" />
              </span>
              <div className="second-menu"  style={{ width: 410, padding: 0 }}>
                <div className="left-list">
                    <a
                      href="#"
                      style={{ backgroundImage: 'url("../images/nav/cuenta-por-cobrar.png")' }}
                    >                
                      <span>Cuentas por cobrar</span>
                      <p>Gestiona las deudas de clientes</p>
                    </a>
                    <a
                      href="#"
                      style={{ backgroundImage: 'url("../images/nav/pay.png")' }}
                    >                
                      <span>Cuentas por pagar</span>
                      <p>Gestiona las deudas a proveedores</p>
                    </a>
                </div>
              </div> 
            </div>

            <div className="nav-item">
              <a href="https://www.mockplus.com/enterprise" className="first-nav">
              <BsPeople size={18} />&nbsp;&nbsp;Terceros
              </a>
            </div> 

            <div className="nav-item">
              <span className="first-nav">
                  <BsBox size={18} />&nbsp;&nbsp;Productos
              </span>       
            </div>    
          </div>

          <div className="right-login">             
            <div className='' onClick={handleChange} style={{paddingTop: "12px"}}>    
              {currentTheme == "dark" ? <BsSun size={19}/> : <BiMoon size={19} />}
            </div>
          </div>
          
          <div className="iconfont  icon_menu icon-color" onClick={abrirMenuCelular} />
          <div className="iconfont  icon_menu_close icon-color" onClick={cerrarMenuCelular}/>
        </div>
    </header>

    </>
  )
}
