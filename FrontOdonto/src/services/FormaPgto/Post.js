import { useEffect, useState } from 'react';
import api from './api';

function Post({metodo,taxa}) {

  const [dados, setDados] = useState();

  useEffect(() => {
    api
        .post("FormaPgto", {
          metodo:{metodo},
          ativo:true,
          taxa:{taxa}
        })
        .then((response) => setDados(response.data))
        .catch((err) => {
            console.error("ops! ocorreu um erro" + err);
        });
},[]);

}

export default Post;