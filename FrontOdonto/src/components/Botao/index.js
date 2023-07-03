import React from 'react'
import { Link } from 'react-router-dom'
import styles from './Botao.module.css'

export default function Botao({url, children}) {


  return (
   <Link to={url} className={styles.botao}>
        {children}
   </Link>
  )
}