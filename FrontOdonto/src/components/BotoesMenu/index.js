import React from 'react'
import styles from './BotoesMenu.module.css'
import { Link } from 'react-router-dom'

export default function BotoesMenu({url, children}) {
  return (
    <Link to={url} className={styles.botao}>
        {children}
   </Link>
  )
}
