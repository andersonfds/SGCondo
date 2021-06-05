/**
 * Types
 */
export enum CondominiumType {
    LOAD_REQUEST = '@condominium/LOAD_REQUEST',
    LOAD_SUCCESS = '@condominium/LOAD_SUCCESS',
    LOAD_FAILURE = '@condominium/LOAD_FAILURE',
}

/**
 * Data types
 */
export interface Condominium {
    id: string;
    name: string;
}

export interface CondominiumFilter {
    name: string;
}

/**
 * State type
 */
export interface CondominiumState {
    readonly data: Condominium[];
    readonly loading: boolean;
    readonly error: boolean;
}