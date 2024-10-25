using System;
using System.Globalization;

namespace Fixacao_1
{
    class Fixacao_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = (Console.ReadLine());
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");
            string tudo = Console.ReadLine();

            string[] dados = tudo.Split(' ');

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(dados[0]);
            Console.WriteLine(dados[1]);
            Console.WriteLine(dados[2]);
        }
    }
}
