import axios from "axios";
import { Environment } from "../helpers/environment";

axios.interceptors.request.use(function (config) {
    return config;
});

export const api = axios.create({
    baseURL: Environment.apiUrl,
});
