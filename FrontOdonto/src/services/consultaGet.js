import { useEffect } from 'react'
import { useDadosContext } from '../context/Dados';
import api from './api';
import { useResultadoContext } from '../context/Resultados';

export default function ConsultaGet() {
    const { resultado } = useResultadoContext();
    const { dados, setDados } = useDadosContext();

    useEffect(() => {
        api
            .get(resultado)
            .then((response) => setDados(response.data))
            .catch((err) => {
                console.error("ops! ocorreu um erro" + err);
            });
    });
}
