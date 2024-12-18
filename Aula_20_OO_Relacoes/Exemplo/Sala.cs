using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes.Exemplo
{
    public class Sala
    {
        public PortaSala PortaSala { get; set; }
    public float MetragemQuadrada { get; set; }
    public Porta PortaAuxiliar { get; set; }

    public Sala(PortaSala portaSala, float metragemQuadrada, Porta portaAuxiliar)
    {
        // Atribui diretamente o objeto portaSala recebido ao campo PortaSala
        PortaSala = portaSala;

        // Atribui os outros parâmetros
        MetragemQuadrada = metragemQuadrada;
        PortaAuxiliar = portaAuxiliar;
    }

    public void AbrirPortaAuxiliar()
    {
        PortaAuxiliar.Abrir();
    }
    }
}