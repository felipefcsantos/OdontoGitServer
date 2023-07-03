import { createContext, useContext, useState } from "react";

export const DadosContext = createContext();
DadosContext.displayName = "Dados";

export default function DadosProvider({children}){
    const [dados, setDados] = useState();

    return(
        <DadosContext.Provider
            value={{dados, setDados}}>
            {children}
        </DadosContext.Provider>
    )
}

export function useDadosContext(){
    const {dados, setDados} = useContext(DadosContext);
    return{
        dados, setDados
    }
}