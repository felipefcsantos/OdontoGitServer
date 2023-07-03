import { createContext, useContext, useState } from "react";

export const ResultadosContext = createContext();
ResultadosContext.displayName = "Resultados";

export default function ResultadosProvider({children}){
    const [resultado, setResultado] = useState();

    return(
        <ResultadosContext.Provider
            value={{resultado, setResultado}}>
            {children}
        </ResultadosContext.Provider>
    )
}

export function useResultadoContext(){
    const {resultado, setResultado} = useContext(ResultadosContext);
    return{
        resultado, setResultado
    }
}