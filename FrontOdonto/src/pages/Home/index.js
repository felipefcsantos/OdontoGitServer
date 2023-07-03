import { useDadosContext } from '../../context/Dados';
import { usePerfilContext } from '../../context/Perfil';
import Botao from '../../components/Botao';
import TelaErro from '../../components/TelaErro';
import Cabecalho from '../../components/Cabecalho';
import styles from './Home.module.css'
import BotoesIniciais from '../../components/BotoesIniciais';

export default function Home() {

    const {dados} = useDadosContext();
    const {perfil, setPerfil} = usePerfilContext();

    setPerfil(dados?.perfil)

    let perfilUsuario = ""

    if (perfil === "A") {
        perfilUsuario = "Adminstrador(a)"
    } else {
        if (perfil === "P") {
            perfilUsuario = "Paciente"
        } else {
            if (perfil === "D") {
                perfilUsuario = "Dentista"
            } else {
                if (perfil === "R") {
                    perfilUsuario = "Recepcionista"
                }
            }
        }
    }

    if (!dados?.cpf) {
        return (
            <TelaErro />
            )
        } else {
            return (
                <>
                <Cabecalho  />
                <div className={styles.container}>
                    <div>
                        <h1>Olá {dados?.apelido},</h1>
                        <h3>Seja bem-vindo(a) ao nosso sistema!</h3>
                        <h3>No momento o seu perfil é de: <u>{perfilUsuario}</u></h3>
                        <h3>Escolha o que deseja fazer agora:</h3>
                        <BotoesIniciais url='/'>Pagamentos</BotoesIniciais>
                        <Botao url='/'>Sair</Botao>
                        <Botao url='/dados'>Dados Pessoais</Botao>
                    </div>
                </div>
            </>
        )
    }

}
