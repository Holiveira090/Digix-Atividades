using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public class Pix : IPagamento
    {
        public string ChavePix { get; set; }
        public string NomeTitular { get; set; }
        public string CPF { get; set; }
        public double Valor { get; set; }
        public DateTime DataPagamento { get; set; }

        // Construtor
        public Pix(string chavePix, string nomeTitular, string cpf, double valor, DateTime dataPagamento)
        {
            ChavePix = chavePix;
            NomeTitular = nomeTitular;
            CPF = cpf;
            Valor = valor;
            DataPagamento = dataPagamento;
        }
        // Implementação do método da interface IPagamento
        public void RealizarPagamento(double valor)
        {
            Valor = valor;
            System.Console.WriteLine($"Pagamento realizado com sucesso via Pix valor: {valor}");
        }
        public void ExibirCompravante()
        {
            System.Console.WriteLine($"Comprovante de pagamento para a chave Pix {ChavePix}, no valor de {Valor:C2}");
        }

    }
}