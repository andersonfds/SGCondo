import React from "react";
import { Button, Form, Row, Spinner } from "react-bootstrap";

export interface CreateCondominiumParams {
    isLoading: boolean;
}

export default class CreateCondominiumForm extends React.Component<unknown, CreateCondominiumParams> {

    constructor(props: any) {
        super(props);
        this.state = {
            isLoading: false,
        };
    }

    async onSubmit() {
        this.setState({ isLoading: true });

    }

    render() {
        return (
            <fieldset className="my-2" disabled={this.state.isLoading}>
                <Form autoComplete="off">
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
                        <Button variant="primary" onClick={() => this.onSubmit()}>
                            {this.state.isLoading ? <Spinner size="sm" animation="grow" /> : 'Salvar'}
                        </Button>
                    </Row>
                </Form>
            </fieldset>
        );
    }

}
