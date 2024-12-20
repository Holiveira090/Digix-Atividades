using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes.Exemplo
{
    public class PortaCozinha : Porta
    {
        public PortaCozinha(string cor, float largura, float altura, double peso) : base(cor, largura, altura, peso)
        {
            
        }
        // subscrevendo o metodo abrir
        public override void Abrir()
        {
            System.Console.WriteLine("Porta da cozinha aberta");
        }
        public override void Fechar()
        {
            System.Console.WriteLine("Porta da cozinha fechada");
        }
    }
}