import axios from "axios";

const apiFormaPgto = axios.create({
  baseURL: "https://localhost:7011/",
});

export default apiFormaPgto;