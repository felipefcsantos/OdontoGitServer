import React from 'react'
import erro from './nao-encontrado.png'
import Botao from '../Botao'
import styles from './TelaErro.module.css'

export default function TelaErro() {
  return (
    <div className={styles.container}>
      <img src={erro} alt='Boneco de Usuário não encontrado'/>
      <p>Usuário não encontrado</p>
      <Botao url='/'> Tente Novamente</Botao>
    </div>
  )
}
