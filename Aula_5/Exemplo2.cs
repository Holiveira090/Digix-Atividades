using System;

namespace Exemplo2
{
    class Exemplo2
    {
        static void Main(string[] args)
        {  
            int [] vetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Digite um número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            int maior = vetor[0];
            int menor = vetor[0];
            for (int i = 1; i < 10; i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
            }
            System.Console.WriteLine($"O maior numero é: {maior}");
            System.Console.WriteLine($"O menor numero é: {menor}");
        }
    }
}
