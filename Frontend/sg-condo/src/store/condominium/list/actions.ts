import { action } from 'typesafe-actions';
import { Condominium, CondominiumType } from './types';

export const loadRequest = () => action(CondominiumType.LOAD_REQUEST);

export const loadSuccess = (data: Condominium[]) => action(CondominiumType.LOAD_SUCCESS, { data });

export const loadFailure = () => action(CondominiumType.LOAD_FAILURE);