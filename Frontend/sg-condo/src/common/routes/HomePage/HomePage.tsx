import React from 'react';
import { Row, Spinner } from 'react-bootstrap';
import { connect } from 'react-redux';
import { bindActionCreators, Dispatch } from 'redux';
import { ApplicationState } from '../../../store';
import * as CondominiumActions from '../../../store/condominium/list/actions';
import { Condominium, CondominiumState } from '../../../store/condominium/list/types';
import CondominiumCard from '../../components/Cards/CondominiumCard';
import CreateCondominiumBlockForm from '../../components/Forms/CreateCondominiumBlockForm';
import CreateCondominiumForm from '../../components/Forms/CreateCondominiumForm';
import Scaffold from '../../components/Scaffold/Scaffold';
import './HomePage.scss';


interface StateProps {
    condominiums: CondominiumState,
}

interface DispatchProps {
    loadRequest(): void,
    loadSuccess(data: Condominium[]): void,
    loadFailure(): void,
}

type Props = StateProps & DispatchProps;

class HomePage extends React.Component<Props> {

    componentDidMount() {
        const { loadRequest } = this.props;
        loadRequest();
    }

    render() {
        const { condominiums } = this.props;
        return (
            <Scaffold>
                <div className="container py-5 h-100 overflow-hidden">
                    <Row className="h-100">
                        <div className="col-6 h-100 scroll">
                            <h1>Condomínios</h1>
                            {
                                condominiums.loading
                                    ?
                                    <div className="text-center py-5"><Spinner animation="grow" /></div>
                                    :
                                    condominiums.error
                                        ?
                                        <div className="text-center py-5">Erro ao carregar os dados</div>
                                        :
                                        condominiums.data.map(x => <CondominiumCard condominium={x} />)
                            }
                        </div>
                        <div className="col-6 px-5">
                            <Row>
                                <h1>Adicionar Condomínio</h1>
                                <CreateCondominiumForm />
                            </Row>

                            <Row>
                                <h1>Inserir Bloco</h1>
                                <CreateCondominiumBlockForm />
                            </Row>

                        </div>
                    </Row>
                </div>
            </Scaffold>
        );
    }
}

const mapStateToProps = (state: ApplicationState) => ({
    condominiums: state.condominiums,
});

const mapDispatchToProps = (dispatch: Dispatch) =>
    bindActionCreators(CondominiumActions, dispatch);

export default connect(mapStateToProps, mapDispatchToProps)(HomePage);