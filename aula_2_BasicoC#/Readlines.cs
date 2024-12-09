using System;

namespace Readline
{
    class Readline
    {
        static void ReadLine()
        {
            // Console.WriteLine("Digite uma palavra: ");
            // string palavra = Console.ReadLine();
            // System.Console.WriteLine($"A palavra digitada foi {palavra}");
            Console.WriteLine("Digite um numero: ");
            double palavra = double.Parse(Console.ReadLine());
            System.Console.WriteLine($"A palavra digitada foi {palavra}");
        }
    }
}
