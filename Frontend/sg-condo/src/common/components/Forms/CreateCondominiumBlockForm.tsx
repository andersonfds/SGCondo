import React from "react";
import { Button, Row } from "react-bootstrap";
import { FiPlus } from 'react-icons/fi';

export default function CreateCondominiumBlockForm() {
    return (
        <Row className="p-0 m-0 align-items-end">
            <div className="col-10">
                <label htmlFor="block_name">Nome do bloco</label>
                <input type="text" id="block_name" className="form-control" />
            </div>
            <div className="col-2">
                <Button className="w-100"><FiPlus /></Button>
            </div>
        </Row>
    );
}