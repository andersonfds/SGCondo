import { all, takeLatest } from 'redux-saga/effects';
import { load } from './condominium/list/sagas';
import createSagaMiddleware from 'redux-saga';
import { CondominiumType } from './condominium/list/types';

export default function* rootSaga(): any {
    return yield all([
        takeLatest(CondominiumType.LOAD_REQUEST, load),
    ]);
}