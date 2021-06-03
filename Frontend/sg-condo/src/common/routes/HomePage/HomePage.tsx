import React, { useState } from 'react';
import Scaffold from '../../components/Scaffold/Scaffold';
import './HomePage.scss';
import { FaBuilding } from "react-icons/fa";
import { Button, Col, Form, Row } from 'react-bootstrap';


export default function HomePage() {
    let [items, setItems] = useState([1, 2, 3]);

    return (
        <Scaffold>
            <div className="container py-5 h-100 overflow-hidden">
                <Row className="h-100">
                    <div className="col-6 h-100 scroll">
                        <h1>Condomínios</h1>
                        <input
                            type="text"
                            className="form-control my-3"
                            placeholder="Buscar condomínios" />

                        {items.map(() => (
                            <article className="card p-2 my-3">
                                <h3>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Possimus, sequi!</h3>
                                <p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Voluptatem, autem!</p>
                            </article>
                        ))}

                    </div>
                    <div className="col-6 px-5">
                        <Row>
                            <Col><h1>Adicionar Condomínio</h1></Col>
                        </Row>

                        <Form autoComplete="off">
                            <fieldset className="my-2">
                                <div className="form-group my-2">
                                    <label htmlFor="name">Nome do Condomínio</label>
                                    <input
                                        type="text"
                                        id="name"
                                        name="name"
                                        className="form-control" />
                                </div>
                                <div className="form-group my-2">
                                    <label htmlFor="cnpj">CNPJ</label>
                                    <input
                                        type="text"
                                        id="cnpj"
                                        name="cnpj"
                                        className="form-control" />
                                </div>
                                <Row className="m-0 p-0 my-3">
                                    <Button variant="primary">Criar</Button>
                                </Row>
                            </fieldset>

                        </Form>
                    </div>
                </Row>
            </div>
        </Scaffold>
    );
}