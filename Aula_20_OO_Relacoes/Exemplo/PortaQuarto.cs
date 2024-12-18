using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes.Exemplo
{
    public class PortaQuarto : Porta
    {
        public PortaQuarto(string cor, float largura, float altura, double peso) : base(cor, largura, altura, peso)
        {
        }
        public override void Abrir()
        {
            System.Console.WriteLine("A porta do quarto foi aberta");
        }
        public override void Fechar()
        {
            System.Console.WriteLine("A porta do quarto foi fechada");
        }
    }
}