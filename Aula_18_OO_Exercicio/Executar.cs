using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;


namespace Aula_18_OO_Exercicio
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Banco banco;
            System.Console.WriteLine("Digite o nome do titular: ");
            string Nome = Console.ReadLine();

            System.Console.WriteLine("Digite o numero da conta: ");
            int NumConta = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Haverá deposito inicial? (s/n)");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                System.Console.WriteLine("Entre com o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                banco = new Banco(Nome, NumConta, depositoInicial);
            }
            else
            {
                banco = new Banco(Nome, NumConta);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Dados da Conta:");
            System.Console.WriteLine(banco);

            System.Console.WriteLine();
            System.Console.WriteLine("Entre com o valor do deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            banco.Depositar(deposito);
            System.Console.WriteLine("Dados atualizados da conta:");
            System.Console.WriteLine(banco);

            System.Console.WriteLine();
            System.Console.WriteLine("Entre com o valor do saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            banco.Sacar(saque);
            System.Console.WriteLine("Dados atualizados da conta:");
            System.Console.WriteLine(banco);


            // Banco b = new Banco("Jão", 123, 1200);
            // System.Console.WriteLine(b);
            // b.Sacar(100);
            // b.Depositar(1000);
            // System.Console.WriteLine(b);
        }
    }
}