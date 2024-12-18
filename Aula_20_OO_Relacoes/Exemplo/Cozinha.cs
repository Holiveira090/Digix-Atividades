using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes.Exemplo
{
    public class Cozinha
    {
        // Vou utilizar Agregação com o objeto PortaCozinha
        public PortaCozinha portaCozinha { get; set; }
        public bool Americana { get; set; }
        public float MetragemQuadrada { get; set; }

        public Cozinha(bool americana, float metragemQuadrada)
        {
            Americana = americana;
            MetragemQuadrada = metragemQuadrada;
        }
        public void Entrar(PortaCozinha portaCozinha)
        {
            System.Console.WriteLine($"Entrou pela porta da cozinha {portaCozinha.Cor}");
        }

    }
}