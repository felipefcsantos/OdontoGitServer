import React, { useState } from 'react'
import styles from './ItensLista.module.css'

export default function ItensLista({onDelete, metodo, juros, ativo}) {
  const [estado, setEstado] = useState(false)

  const alteracao = () => {
    setEstado(!estado)
    ativo=(estado)
  }

  return (
    <div className={styles.container}>
        Metodo:
        <input className={styles.input} value={metodo} readOnly/>
        Juros:
        <input className={styles.input} value={juros} readOnly/>
        Ativo:
        <input value={estado} onClick={alteracao} type='checkbox' onChange={ativo}/>
        <button onClick={onDelete}>Deletar</button>
    </div>
  )
}
