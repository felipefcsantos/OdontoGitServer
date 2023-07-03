import React from 'react'
import logo from '../../images/logo.png'
import styles from './Cabecalho.module.css'
import BotoesMenu from '../BotoesMenu'
import { usePerfilContext } from '../../context/Perfil'


export default function Cabecalho() {
    const { perfil } = usePerfilContext();

    if (perfil === "A" || perfil === "R") {
        return (
            <header className={styles.cabecalho}>
                <img className={styles.logo} src={logo} alt='Logo' />
                <div>
                    <BotoesMenu url={'/resultado'}>Home</BotoesMenu>
                    <BotoesMenu url={'/formapgto'}>Pagamentos</BotoesMenu>
                </div>
            </header>
        )
    } else {
        return (
            <header className={styles.cabecalho}>
                <img className={styles.logo} src={logo} alt='Logo' />
                <BotoesMenu url={'/resultado'}>Home</BotoesMenu>
            </header>
        )
    }


}
