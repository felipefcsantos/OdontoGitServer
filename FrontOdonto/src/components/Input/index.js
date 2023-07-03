import React from 'react'
import styles from './Input.module.css'
import { useResultadoContext } from '../../context/Resultados';
import Botao from '../Botao/index';
import logo from '../../images/logo.png';
import login from './login.png';
import senha from './senha.png';

export default function Input() {
    const { resultado, setResultado } = useResultadoContext();
    return (
        <div className={styles.container}>
            <img className={styles.logo} src={logo} alt='Logo'/>
            <form>
                <img className={styles.login} src={login} alt='Boneco de login'/>
                <input
                    onChange={event => setResultado(event.target.value)}
                    value={resultado}
                    placeholder='CPF'
                />
            </form>
            <form>
                <img className={styles.senha} src={senha} alt='Cadeado'/>
                <input
                    placeholder='Senha'
                />
            </form>
                <Botao url='./resultado'>Entrar </Botao>
        </div>
    )
}
