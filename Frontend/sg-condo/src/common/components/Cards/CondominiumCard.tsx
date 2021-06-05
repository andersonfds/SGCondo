import React from "react";
import { Condominium } from "../../../store/condominium/list/types";


interface StateProps {
}

interface DispatchProps {
}

interface OwnProps {
    condominium: Condominium,
}

type Props = StateProps & DispatchProps & OwnProps;


export default class CondominiumCard extends React.Component<Props> {
    render() {
        const { condominium } = this.props;
        return (
            <article className="card p-2 my-3">
                <h3>{condominium.name}</h3>
            </article>
        );
    }
}