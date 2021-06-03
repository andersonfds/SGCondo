import classNames from 'classnames';
import React, { useState } from 'react';
import { Button, Col, Dropdown, Row } from 'react-bootstrap';
import { CgMenuLeftAlt } from "react-icons/cg";
import { GoPerson } from "react-icons/go";
import { FaCouch, FaBuilding } from "react-icons/fa";
import './Scaffold.scss';

export default function Scaffold(props: any) {
    const [menu, setMenu] = useState(false);

    function toggleMenu() {
        setMenu(!menu);
    }

    return (
        <div className={classNames('h-100 menu-container', { 'menu-active': menu })}>
            <div className="overflow" onClick={toggleMenu}></div>
            <Row className="h-100 m-0 overflow-hidden">
                <Col lg="2" className='fixed-md-left responsive-menu h-100 p-0'>
                    <div className="responsive-menu-container">
                        <div className="w-100">
                            <div className="scroll h-100">
                                <h1 className="text-center py-3">SGC</h1>
                                <div className="px-3">
                                    <input type="text" placeholder="Busque aqui" className="menu-search" />
                                </div>
                                <nav className="menu-items">
                                    <ul>
                                        <li>
                                            <FaBuilding />
                                            <span>Condomínios</span>
                                        </li>
                                        <li>
                                            <FaCouch />
                                            <span>Residentes</span>
                                        </li>
                                    </ul>
                                </nav>
                            </div>
                        </div>
                    </div>
                </Col>
                <Col lg="10" md="12" className="h-100 d-flex p-0 flex-column">
                    <header className="row sticky-top header-container m-0 py-2 flex-shrink-0">
                        <Col>
                            <Row className="align-items-center justify-content-between">
                                <div className="col-4">
                                    <div className="d-flex align-items-center">
                                        <Button variant="none" onClick={toggleMenu} className="d-lg-none">
                                            <CgMenuLeftAlt />
                                        </Button>
                                        <div className="mx-3">SG Condo</div>
                                    </div>
                                </div>

                                <div className="col-3">
                                    <Row className="justify-content-end">
                                        <div className="col-2 my-2">
                                            <Dropdown>
                                                <Dropdown.Toggle variant="none" id="account-data">
                                                    <GoPerson />
                                                </Dropdown.Toggle>

                                                <Dropdown.Menu className="custom-dropdown">
                                                    <Dropdown.Item href="/">Sair</Dropdown.Item>
                                                </Dropdown.Menu>
                                            </Dropdown>
                                        </div>
                                    </Row>
                                </div>
                            </Row>
                        </Col>
                    </header>
                    <div className="h-100 overflow-hidden">{props.children}</div>
                </Col>
            </Row>
        </div>
    );
}