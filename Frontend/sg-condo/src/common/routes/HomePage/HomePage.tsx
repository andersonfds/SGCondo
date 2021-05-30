import React from 'react';
import './HomePage.scss';


export default function HomePage() {
    return (
        <div className="col-12 scroll h-100">
            <header className="app-bar sticky-top">
                <div className="col-10 m-auto">
                    <div className="row align-items-center justify-content-between">
                        <div className="col-lg-2">
                            SG-Condomínio
                        </div>

                        <div className="col-lg-2 py-3">
                            <div className="row justify-content-end">
                                <div className="col-6">
                                    <button className="btn btn-danger w-100">Sair</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </header>

            <div className="col-8 m-auto my-4">

                <div className="row">

                    <div className="col-3">
                        <input type="text" className="w-100 form-control" placeholder="Buscar condomínios" />
                        <div className="my-4">
                            <div className="condo-card p-4 active my-2">
                                <h6>Condomínio Alphaville</h6>
                                <p>Lorem ipsum dolor</p>
                            </div>

                            <div className="condo-card p-4 my-2">
                                <h6>Condomínio Alphaville</h6>
                                <p>Lorem ipsum dolor</p>
                            </div>

                            <p className="text-center py-4">Sem resultados</p>
                        </div>
                    </div>

                    <div className="col-7 offset-1">
                        <h1>Condomínio</h1>
                        <div className="my-4 expressive w-100">
                            <h3 className="p-4 pb-0">Detalhes do Condomínio</h3>
                            <div className="tall-box px-4">
                                <div className="form-group my-3">
                                    <label htmlFor="condo-name">Nome do condomínio</label>
                                    <input id="condo-name" type="text" className="form-control" placeholder="Nome do Condomínio" />
                                </div>
                                <div className="form-group my-3">
                                    <label htmlFor="condo-name">Nome do condomínio</label>
                                    <input id="condo-name" type="text" className="form-control" placeholder="Nome do Condomínio" />
                                </div>
                            </div>
                        </div>
                        <div className="my-4 expressive w-100">
                            <h3 className="p-4 pb-0">Residentes</h3>
                            <div className="tall-box px-4">
                                <div className="form-group my-3">
                                    <label htmlFor="condo-name">Buscar residentes</label>
                                    <input type="text" className="form-control" placeholder="Buscar residentes" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    );
}