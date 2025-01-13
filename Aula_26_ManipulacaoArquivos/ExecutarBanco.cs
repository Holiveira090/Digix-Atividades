using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula26_ManipulacaoArquivo.Banco;
using ClosedXML.Excel;

namespace Aula_26_ManipulacaoArquivos
{
    public class ExecutarBanco
    {
        static void Main(string[] args)
        {
            var cliente = new Customer("João de Deus");
            var contaCorrente = new CurrentAccount(1234, cliente, 500);
            var contaPoupanca = new SavingAccount(4321, cliente, 0.01);

            contaCorrente.Depositar(100);
            contaCorrente.Sacar(200);

            contaPoupanca.Depositar(100);
            contaPoupanca.AplicarRendimento();

            // Geração Excel
            GerarExcel(new List<Account> { contaCorrente, contaPoupanca });
        }


        public static void GerarExcel(List<Account> contas)
        {
            // Geração Excel
            // Vamos instalar ClosedXML
            // dotnet add package ClosedXML
            // Rodar no terminal
            using (var workbook = new XLWorkbook())
            {
                // Aqui estamos criando o arquivo COntas bancarias em excel
                var worksheet = workbook.Worksheets.Add("Contas Bancarias");

                // Cabecalho
                worksheet.Cell(1, 1).Value = "Numero da Conta"; // cell é a celula no excel
                worksheet.Cell(1, 2).Value = "Numero do Cliente";
                worksheet.Cell(1, 3).Value = "Tipo da Conta";
                worksheet.Cell(1, 4).Value = "Saldo";

                // Configurar para preencher a partir da linha 2
                int row = 2; // row é linha
                foreach (var item in contas)
                {
                    worksheet.Cell(row, 1).Value = item.NumeroConta;
                    worksheet.Cell(row, 2).Value = item.Cliente.Nome;
                    worksheet.Cell(row, 3).Value = item.TipoConta.ToString();
                    worksheet.Cell(row, 4).Value = item.Saldo;
                    row++; // Para ir para a proxima linha sucessivamente
                }

                workbook.SaveAs("ContasBancarias.xlsx");
                System.Console.WriteLine("Arquivo Excel gerado com sucesso");
            }
        }
    }
}