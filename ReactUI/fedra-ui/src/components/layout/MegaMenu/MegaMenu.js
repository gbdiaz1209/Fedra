import React, { useState } from 'react'

import Dropdown from 'react-bootstrap/Dropdown';
import { NavDropdown } from 'react-bootstrap';
import Container from 'react-bootstrap/Container';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import Nav from 'react-bootstrap/Nav';

import { FaAngleDown } from 'react-icons/fa';

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
        {icon} {menuName} {" "} <FaAngleDown size={19} />
      </div>
    );
  }

  return (
    <NavDropdown 
      title={<CustomToggle />} 
      id={id}   
      show={show}           
      onMouseEnter={() => setShow(true)}
      onMouseLeave={() => setShow(false)}         
      className='d-inline-flex align-items-center '
      renderMenuOnMount={true}>
          <Container className="dropdown-mega-menu fade-in">
            <Row>
              <Col xs="12" md="6" className="text-left">
                <Dropdown.Header>
                  {/* <FontAwesomeIcon
                    color="black"
                    icon={"concierge-bell"}
                    size="1x"
                    className="pr-1"
                  /> */}
                  {"  "}
                  Catering
                </Dropdown.Header>
                <Dropdown.Item>
                  <Nav.Link href="/">
                    <a className="nav-link" role="button">
                      Corporate
                    </a>
                  </Nav.Link>
                </Dropdown.Item>
                <Dropdown.Item>
                  <Nav.Link href="/">
                    <a className="nav-link" role="button" >
                      Private
                    </a>
                  </Nav.Link>
                </Dropdown.Item>

                <Dropdown.Divider />
                <Dropdown.Header>
                  {/* <FontAwesomeIcon
                    color="black"
                    icon={"chalkboard-teacher"}
                    size="1x"
                    className="pr-1"
                  /> */}
                  {"  "}
                  Classes
                </Dropdown.Header>
                <Dropdown.Item>
                  <Nav.Link href="/">
                    <a className="nav-link" role="button">
                      Barista 101
                    </a>
                  </Nav.Link>
                </Dropdown.Item>
                <Dropdown.Item>
                  <Nav.Link href="/">
                    <a className="nav-link" role="button">
                      History of Coffee
                    </a>
                  </Nav.Link>
                </Dropdown.Item>
                <Dropdown.Item>
                  <Nav.Link href="/">
                    <a className="nav-link" role="button">
                      Intro to Cafe Snobbery
                    </a>
                  </Nav.Link>
                </Dropdown.Item>
                <Dropdown.Divider className="d-md-none" />
              </Col>

              <Col xs="12" md="6" className="text-left">
                <Dropdown.Header>
                  {/* <FontAwesomeIcon
                    color="black"
                    icon={"building"}
                    size="1x"
                    className="pr-1"
                  /> */}
                  {"  "}
                  Rentals
                </Dropdown.Header>
                <Dropdown.Item>
                  <Nav.Link href="/">
                    <a className="nav-link" role="button">
                      Fireside Room
                    </a>
                  </Nav.Link>
                </Dropdown.Item>
                <Dropdown.Item>
                  <Nav.Link href="/">
                    <a className="nav-link" role="button">
                      Roasting Room
                    </a>
                  </Nav.Link>
                </Dropdown.Item>
                <Dropdown.Divider />
                <Dropdown.Header>
                  {/* <FontAwesomeIcon
                    color="black"
                    icon={"sun"}
                    size="1x"
                    className="pr-1"
                  /> */}
                  {"  "}
                  Seasonal
                </Dropdown.Header>
                <Dropdown.Item>
                  <Nav.Link href="/">
                    <a className="nav-link" role="button">
                      Coldbrew Night
                    </a>
                  </Nav.Link>
                </Dropdown.Item>
                <Dropdown.Item>
                  <Nav.Link href="/">
                    <a className="nav-link text-wrap" role="button">
                      Campfire Coffee Class
                    </a>
                  </Nav.Link>
                </Dropdown.Item>
              </Col>
            </Row>
          </Container>
    </NavDropdown>
  );

 
}

