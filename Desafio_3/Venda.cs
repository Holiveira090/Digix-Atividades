using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_3
{
    public class Venda
    {
        public Produto[] Produtos { get; set; }
        public DateTime Data{ get; set; }
        public Vendedor Vendedor{ get; set; }
        public string FormaPagamento{ get; set; }
        public int Parcelas{ get; set; }
        public double ValorTotal{ get; set; }
        public Cliente Cliente{ get; set; }
        public double CalcularValorFinal()
        {
            Imposto imposto = new Imposto();
            double valorFinal = 0;
            foreach (var produto in Produtos)
            {
                valorFinal += produto.CalcularPrecoFinal();
            }
            return valorFinal - imposto.CalcularImpostoVendas();
        }
    }
}