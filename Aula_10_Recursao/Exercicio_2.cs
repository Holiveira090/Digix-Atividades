using System;

namespace Exercicio_2
{
    class Exercicio_2
    {
       static int Produto(int n)
       {
        if (n == 1)
        {
            return 1;
        }
        return n * Produto(n - 1);
       }
        
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um numero: ");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"O produto dos numeros de 1 a {n} é: {Produto(n)}");
        }
    }
}