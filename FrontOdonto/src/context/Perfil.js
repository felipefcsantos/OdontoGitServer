import { createContext, useContext, useState } from "react";

export const PerfilContext = createContext();
PerfilContext.displayName = "Perfil";

export default function PerfilProvider({children}){
    const [perfil, setPerfil] = useState();

    return(
        <PerfilContext.Provider
            value={{perfil, setPerfil}}>
            {children}
        </PerfilContext.Provider>
    )
}

export function usePerfilContext(){
    const {perfil, setPerfil} = useContext(PerfilContext);
    return{
        perfil, setPerfil
    }
}