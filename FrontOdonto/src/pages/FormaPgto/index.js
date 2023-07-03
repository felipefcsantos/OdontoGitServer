import { useState } from 'react'
import Cabecalho from '../../components/Cabecalho'
import styles from './FormaPgto.module.css'
import NovoPagamento from '../../components/NovoItem'
import ItensLista from '../../components/ItensLista'

export default function FormaPgto() {
  const [pagamentos, setPagamentos] = useState([])

  const addNovoPagamento = (metodo, juros) => {
    const copiaItens = Array.from(pagamentos)
    copiaItens.push({ id: pagamentos.length, metodo: metodo, juros: juros })
    setPagamentos(copiaItens)
  }

  // const editarPagamento = ({target}, index) => {
  //   const copiaItens = Array.from(pagamentos)
  //   copiaItens.splice(index, 1, {id: index.length, metodo: target.value})
  //   setPagamentos(copiaItens)
  // }

  // const editarJuros = ({target}, index) => {
  //   const copiaItens = Array.from(pagamentos)
  //   copiaItens.splice(index, 1, {id: index.length, juros: target.value})
  //   setPagamentos(copiaItens)
  // }

  const deletarPagamento = (index) => {
    const copiaItens = Array.from(pagamentos)
    copiaItens.splice(index, 1)
    setPagamentos(copiaItens)
  }

  const ativado = ({ target }, index) => {

    console.log(target.value + index);
  }

  return (
    <>
      <Cabecalho />
      <div className={styles.container}>
        <NovoPagamento onSubmit={addNovoPagamento} />
        {pagamentos.map(({ id, metodo, juros }, index) => (
          <ItensLista
            key={id}
            metodo={metodo}
            juros={juros}
            onDelete={() => deletarPagamento(index)}
            ativo={(event) => ativado(event, index)}
          />
        ))}
      </div>
    </>
  )
}
