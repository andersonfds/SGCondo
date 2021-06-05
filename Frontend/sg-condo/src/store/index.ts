import { applyMiddleware, createStore, Store } from 'redux';
import { CondominiumState } from './condominium/list/types';
import createSagaMiddleware from 'redux-saga';
import rootReducer from './rootReducer';
import rootSaga from './rootSaga';

export interface ApplicationState {
    condominiums: CondominiumState,
}

const sagaMiddleware = createSagaMiddleware();

const store: Store<ApplicationState> = createStore(rootReducer, applyMiddleware(sagaMiddleware));

sagaMiddleware.run(rootSaga);

export default store;