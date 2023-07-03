import { useEffect, useState } from 'react'
import apiFormaPgto from './api';

export default function GetFormaPgto() {
  const [ pagamentos, setPagamentos ] = useState([]);

  useEffect(() => {
    apiFormaPgto
      .get("FormaPgto")
      .then((response) => setPagamentos(response.data))
      .catch((err) => {
        console.error("ops! ocorreu um erro" + err);
      });
  }, []);


  return (
    <div>
      {pagamentos.map((pag) =>
          <li key={pag?.idFormaDePagamento}>{pag?.metodo}</li>
        )}

    </div>
  );
} 