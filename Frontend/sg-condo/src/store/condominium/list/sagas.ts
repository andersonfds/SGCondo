import { AxiosResponse } from 'axios';
import { call, put } from 'redux-saga/effects'
import { api } from "../../../common/services/api";
import { loadFailure, loadSuccess } from './actions';
import { Condominium } from './types';

export function* load() {
    try {
        const response: AxiosResponse<Condominium[]> = yield call(api.get, '/condominium');
        yield put(loadSuccess(response.data));
    } catch (err) {
        yield put(loadFailure());
    }
}