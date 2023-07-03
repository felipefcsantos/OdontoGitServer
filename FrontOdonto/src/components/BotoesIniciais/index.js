import React from 'react'
import { Link } from 'react-router-dom'
import carteira from './carteira.svg'

export default function BotoesIniciais({url, children}) {
  return (
    <div>
        <img src={carteira}/>
   <Link to={url}>
        {children}
   </Link>
   </div>
  )
}
