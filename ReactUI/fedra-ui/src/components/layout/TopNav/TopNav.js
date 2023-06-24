import React, { useEffect, useState } from 'react'
import './TopNav.css'

import { BsPeople, BsBox, BsHouse } from 'react-icons/bs';
import { TbFileInvoice } from 'react-icons/tb';
import { SlNotebook } from 'react-icons/sl';
import { CgMenuGridO } from 'react-icons/cg';
import { FaAngleDown } from 'react-icons/fa';
import { BiMoon, BiSun } from 'react-icons/bi';
import { BsSun } from 'react-icons/bs';

import { getCurrenttheme, toggleTheme } from '../Theme/ConfigTheme';
import FedraIcon from '../FedraIcon';


export const TopNav = () => {
  
  const [currentTheme, setCurrentTheme] = useState("");

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
    <header className="header-of-page container-xxl bd-gutter flex-wrap flex-lg-nowrap">
       <div className="header-content">
        <div className="left-logo">
         <FedraIcon />     
    </div>
    <div className="header-nav ">
      <div className="nav-item">
        <span className="first-nav">
        <BsHouse size={18}/>&nbsp;&nbsp;Dashboard
          <i className="iconfont icon_broad_back" />
        </span>
        <div className="second-menu">
          <div className="left-list">
            <div className="top-titles">Features</div>
            <a
              href="https://www.mockplus.com/mockplus-rp"
              style={{ backgroundImage: 'url("../images/nav/pic1.png")' }}
            >
              <span>Prototyping</span>
              <p>Free web &amp; app prototyping tool</p>
            </a>
            <a
              href="https://www.mockplus.com/free-wireframing-tool"
              style={{ backgroundImage: 'url("../images/nav/pic2.png")' }}
            >
              <span>Wireframing</span>
              <p>Free online wireframing tool</p>
            </a>
            <a
              href="https://www.mockplus.com/ux-design-tool"
              style={{ backgroundImage: 'url("../images/nav/pic3.png")' }}
            >
              <span>UX design</span>
              <p>Design tool for UX team</p>
            </a>
            <a
              style={{ backgroundImage: 'url("../images/nav/pic4.png")' }}
              id="head-nav-download-rp"
            >
              <span>Download App</span>
              <p>Prototyping offline software</p>
            </a>
            <div className="top-titles-line">
              Need an offline prototyping software？
            </div>
            <a
              href="https://www.mockplus.com/download/mockplus-classic"
              style={{ backgroundImage: 'url("../images/nav/pic8.png")' }}
            >
              <span>Mockplus Classic</span>
              <p>A rapid desktop prototyping tool</p>
            </a>
          </div>
          <div className="line" />
          <div className="right-cons">
            <div className="top-titles">
              Templates
              <a href="https://www.mockplus.com/example/rp" className="more">
                See all <i className="iconfont icon_tag_right_arrow" />
              </a>
            </div>
            <a href="https://www.mockplus.com/example/rp/92" className="a1">
              App wireframe kits
            </a>
            <a href="https://www.mockplus.com/example/rp/90" className="a1">
              Low-fi wireframe
            </a>
            <a href="https://www.mockplus.com/example/rp/100" className="a1">
              High-fi wireframe
            </a>
            <a href="https://www.mockplus.com/example/rp/58" className="a1">
              Free UI Kits
            </a>
            <div className="top-titles">Why Mockplus RP</div>
            <a href="https://www.mockplus.com/mockplus-vs-axure" className="a1">
              Compare Axure
            </a>
            <a
              href="https://www.mockplus.com/mockplus-vs-justinmind"
              className="a1"
            >
              Compare Justinmind
            </a>
            <a href="https://help.mockplus.com/p/401" className="a1">
              Create your first prototype
            </a>
            <a href="https://www.mockplus.com/learn/prototype" className="a1">
              Learn prototyping
            </a>
            <div className="top-titles">Learn</div>
            <a
              href="https://www.mockplus.com/learn/what-is-mockplus-rp"
              className="a1"
            >
              What is Mockplus RP ?{" "}
            </a>
          </div>
        </div>
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
            <div className="top-titles">Solutions</div>
            <a
              href="https://www.mockplus.com/cloud?home=1&type=designer#collaboration"
              style={{ backgroundImage: 'url("../images/nav/pic5.png")' }}
            >
              <span>For Designers</span>
              <p>Import Figma, Sketch, XD and PS files</p>
            </a>
            <a
              href="https://www.mockplus.com/cloud?home=1&type=developer#collaboration"
              style={{ backgroundImage: 'url("../images/nav/pic6.png")' }}
            >
              <span>For Developers</span>
              <p>Get all the assets, specs and code</p>
            </a>
            <a
              href="https://www.mockplus.com/cloud?home=1&type=team#collaboration"
              style={{ backgroundImage: 'url("../images/nav/pic7.png")' }}
            >
              <span>For Product Teams</span>
              <p>Manage projects and product updates</p>
            </a>
            <div className="top-titles">Learn</div>
            <a
              href="https://www.mockplus.com/learn/what-is-mockplus-cloud"
              className="a1"
            >
              What is Mockplus Cloud ?{" "}
              <i className="iconfont icon_tag_right_arrow" />
            </a>
          </div>
          <div className="line" />
          <div className="right-cons">
            <div className="top-titles">
              Integrations
              <a
                href="https://www.mockplus.com/cloud-integrations"
                className="more"
              >
                See all <i className="iconfont icon_tag_right_arrow" />
              </a>
            </div>
            <a href="https://help.mockplus.com/p/498" className="a1">
              Figma
            </a>
            <a href="https://help.mockplus.com/p/249" className="a1">
              Photoshop
            </a>
            <a href="https://help.mockplus.com/p/251" className="a1">
              Adobe XD
            </a>
            <a href="https://help.mockplus.com/p/250" className="a1">
              Sketch
            </a>
            <div className="top-titles">Why Mockplus Cloud</div>
            <a
              href="https://www.mockplus.com/mockplus-vs-invision"
              className="a1"
            >
              Compare InVision
            </a>
            <a
              href="https://www.mockplus.com/mockplus-vs-zeplin"
              className="a1"
            >
              Compare Zeplin
            </a>
            <a
              href="https://www.mockplus.com/remote-design-collaboration"
              className="a1"
            >
              Collaborate remotely
            </a>
            <a href="https://www.mockplus.com/mockplus-ds" className="a1">
              Manage design systems
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
          <i className="iconfont icon_broad_back" />
        </span>
        <div className="second-menu" style={{ width: 252, padding: 16 }}>
          <a href="mockplus-rp.html" className="price-a">
            <img src="../images/nav/rp1.png" alt="" />
            Inventario
          </a>
          <a href="mockplus-cloud.html" className="price-a">
            <img src="../images/nav/cc.png" alt="" />
            Categorías
          </a>
        </div>
      </div>
      <div className="nav-item">
        <span className="first-nav">
           <BsPeople size={18} />&nbsp;&nbsp;Cuentas
          <i className="iconfont icon_broad_back" />
        </span>
        <div className="second-menu" style={{ width: 252, padding: 16 }}>
          <a href="mockplus-rp.html" className="price-a">
            <img src="../images/nav/rp1.png" alt="" />
            Cuentas por cobrar
          </a>
          <a href="mockplus-cloud.html" className="price-a">
            <img src="../images/nav/cc.png" alt="" />
            Cuentas por Pagar
          </a>
        </div>
      </div>
    </div>
    <div className="right-login">             
      <div onClick={handleChange} style={{paddingTop: "12px"}}>    
        {currentTheme == "dark" ? <BsSun size={19}/> : <BiMoon size={19} />}
      </div>
    </div>
    <div className="iconfont icon_menu icon-color" />
    <div className="iconfont icon_menu_close icon-color" />
  </div>
</header>

    </>
  )
}
