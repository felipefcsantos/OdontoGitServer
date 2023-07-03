import React, { useState } from 'react'
import styles from './NovoPagamento.module.css'

export default function NovoPagamento({ onSubmit}) {
  const [novoItem, setNovoItem] = useState("")
  const [metodo, setMetodo] = useState("")
  const [juros, setJuros] = useState()


  
  const setNovoMetodo = ({ target }) => {
    setMetodo(target.value)
  }
  
  const setNovoJuros = ({ target }) => {
    setJuros(target.value)
  }


  const submit = (event) => {
    event.preventDefault();
    onSubmit(metodo, juros)
    setNovoItem('')
  }

  return (
    <div>
      <form onSubmit={submit}>
        <input
          onChange={setNovoMetodo}
          placeholder='Método (Ex: Dinheiro)'
          className={styles.input}
          value={metodo}
        />

        <input
          onChange={setNovoJuros}
          placeholder='Taxa em % (Ex: 3.5)'
          className={styles.input}
          value={juros}
        />
        <button type='submit' className={styles.botao} >Criar Pagamento</button>
      </form>
    </div>
  )
}
