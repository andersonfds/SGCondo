import { stat } from "fs";
import { Reducer } from "redux";
import { CondominiumState, CondominiumType } from "./types";

const INITIAL_STATE: CondominiumState = {
    data: [],
    error: false,
    loading: false,
};


const reducer: Reducer<CondominiumState> = (state = INITIAL_STATE, action) => {
    switch (action.type) {
        case CondominiumType.LOAD_REQUEST:
            return { ...state, loading: true }
        case CondominiumType.LOAD_SUCCESS:
            return { ...state, loading: false, error: false, data: action.payload.data }
        case CondominiumType.LOAD_FAILURE:
            return { ...state, loading: false, error: true }
        default:
            return state;
    }
};

export default reducer;