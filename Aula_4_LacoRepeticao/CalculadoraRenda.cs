using System;

namespace CalculadoraRenda
{
    class CalculadoraRenda
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de investimento inicial: ");
            double valorI = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual investimento deseja aplicar?\n1 - Poupança (3% ao ano)\n2 - Renda Fixa (5% ao ano)\n3 - Ações (10% ao ano com chance de perda de 5%)");
            int investimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos anos deseja investir? ");
            int anos = int.Parse(Console.ReadLine());

            double valorTotal = valorI; 

            for (int i = 1; i <= anos; i++)
            {
                switch (investimento)
                {
                    case 1: 
                        valorTotal *= 1.03; 
                        break;
                    case 2: 
                        valorTotal *= 1.05; 
                        break;
                    case 3:
                        Random rand = new Random();
                        double percentual = rand.NextDouble() < 0.5 ? 0.10 : -0.05; 
                        valorTotal *= (1 + percentual);
                        break;
                    default:
                        Console.WriteLine("Opção de investimento inválida.");
                        return;
                }

                Console.WriteLine($"Rendimento no ano {i}: {valorTotal:F2}");
            }
        }
    }
}
