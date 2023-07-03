import axios from "axios";

const api = axios.create({
  baseURL: "https://my-json-server.typicode.com/felipefcsantos/teste-usuario/",
});

export default api;