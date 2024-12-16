using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public class CartaoCredito : IPagamento, IAnuidade
    {
        public string NumeroCartao { get; set; }
        public DateTime DataVencimento { get; set; }
        public double ValorAnuidade { get; set; }

        // Construtor
        public CartaoCredito(string numeroCartao)
        {
            NumeroCartao = numeroCartao;
        }
        public CartaoCredito(string numeroCartao, DateTime dataVencimento, double valorAnuidade)
        {
            NumeroCartao = numeroCartao;
            DataVencimento = dataVencimento;
            ValorAnuidade = valorAnuidade;
        }

        public void RealizarPagamento(double valor)
        {
            System.Console.WriteLine($"Pagamento de {valor:C2} realizado com sucesso!");
        }
        public void ExibirCompravante()
        {
            System.Console.WriteLine($"Comprovante de pagameto com o cartão {NumeroCartao} no dia {DateTime.Now}");
        }

        // Importar a interdace IAnuidade
        public DateTime CalcularDataVencimento()
        {
            return DateTime.Now.AddYears(1);
        }
        public double CalcularValorAnuidade()
        {
            return 100; // Valor fixo da anuidade
        }



    }
}