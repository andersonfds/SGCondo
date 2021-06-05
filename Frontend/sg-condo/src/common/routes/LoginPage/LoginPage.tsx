import React from 'react';
import { useHistory } from 'react-router';
import './LoginPage.scss';


export default function LoginPage() {
    const history = useHistory();

    function enter() {
        history.push('home');
    }

    return (
        <div className="h-100">
            <div className="col-lg-3 col-sm-6 m-auto h-100">
                <div className="d-flex h-100 px-4 align-items-center">
                    <form autoComplete="off" className="w-100">
                        <div>
                            <label htmlFor="email">E-mail</label>
                            <input id="email" type="text" className="form-control" placeholder="voce@exemplo.com" />
                        </div>
                        <div className="mt-2">
                            <label htmlFor="password">Senha</label>
                            <input id="password" type="password" className="form-control" placeholder="12345678" />
                        </div>
                        <button type="button" className="btn btn-primary w-100 mt-4" onClick={enter}>Entrar</button>
                    </form>
                </div>
            </div>
        </div>
    );
}
