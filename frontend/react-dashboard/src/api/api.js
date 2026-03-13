import axios from "axios";
const api = axios.create({
    baseURL: "http://localhost:5265"
});

export default api;