using System;

namespace Exercicio_1
{
    class Exercicio_1
    {
        static void ex1()
        {
          //area do triângulo
            // Console.WriteLine("Digite a base do triângulo: ");
            // double num1 = Convert.ToDouble(Console.ReadLine()); 
            // Console.WriteLine("Digite a altura do triângulo: ");
            // double num2 = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine($"A área do triângulo é: {num1 * num2 / 2}");

            //area do quadrado
            // System.Console.WriteLine("Digite a base do quadrado: ");
            // double num1 = Convert.ToDouble(Console.ReadLine());
            // System.Console.WriteLine("Digite a altura do quadrado: ");
            // double num2 = Convert.ToDouble(Console.ReadLine());

            // System.Console.WriteLine($"A area do quadrado é igual a: {num1 * num2}");

            //area do circulo
            System.Console.WriteLine("Digite o raio do circulo: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine($"A area do ciculo é igual a: {3.14 * Math.Pow(num1, 2)}");

        }
    }
}
