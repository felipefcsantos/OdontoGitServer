import React from 'react'
import { BrowserRouter, Route, Routes } from 'react-router-dom'
import ResultadosProvider from './context/Resultados'
import Login from './pages/Login'
import Home from './pages/Home'
import DadosPessoais from './pages/DadosPessoais'
import DadosProvider from './context/Dados'
import ConsultaGet from './services/consultaGet'
import FormaPgto from './pages/FormaPgto'
import PerfilProvider from './context/Perfil'

export default function AppRoutes() {
    return (
        <BrowserRouter>
            <ResultadosProvider>
                <DadosProvider>
                    <PerfilProvider>
                        <ConsultaGet />
                        <Routes>
                            <Route path='/' element={<Login />} />
                            <Route path='/resultado' element={<Home />} />
                            <Route path='/dados' element={<DadosPessoais />} />
                            <Route path='/formapgto' element={<FormaPgto />} />
                        </Routes>
                    </PerfilProvider>
                </DadosProvider>
            </ResultadosProvider>
        </BrowserRouter>
    )
}
