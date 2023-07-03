import React from 'react'
import { useDadosContext } from '../../context/Dados'
import styles from './DadosPessoais.module.css'
import Cabecalho from '../../components/Cabecalho';
import Botao from '../../components/Botao';

export default function DadosPessoais() {
    const { dados } = useDadosContext();
    return (
        <>
            <Cabecalho perfil={dados.perfil} />
            <div className={styles.container}>
                <div>
                    <p><strong>Nome: </strong>{dados.nome}</p>
                    <p><strong>Sobrenome: </strong>{dados.sobrenome}</p>
                    <p><strong>CPF: </strong>{dados.cpf}</p>
                    <p><strong> E-mail: </strong>{dados.email}</p>
                    <Botao url='/resultado'>Voltar</Botao>
                </div>
            </div>
        </>
    )
}
