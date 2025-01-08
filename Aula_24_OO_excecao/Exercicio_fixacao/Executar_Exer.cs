using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_24_OO_excecao.Exercicio_fixacao
{
    public class Executar_Exer
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o numero da conta: ");
            int number = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o nome do titular: ");
            string holder = Console.ReadLine();


            Account account = new Account(number, holder);
            System.Console.WriteLine("Digite o valor do deposito: ");
            double amount = double.Parse(Console.ReadLine());
            account.Deposit(amount);
            account.ExibirInformacoes();
            System.Console.WriteLine("Digite o valor do saque: ");
            amount = double.Parse(Console.ReadLine());
            account.Withdraw(amount);
            account.ExibirInformacoes();
        }
    }
}