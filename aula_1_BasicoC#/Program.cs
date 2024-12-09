using System;
namespace Exemplo
{
    internal class Program
    {
        static void Teste()
        {
            int idade = 25;
            double saldo = 10.50;
            string nome = "Henrique Oliveira";

            Console.WriteLine("Olá "+ nome + ", sua idade é "+ idade + " o saldo é de "+ saldo);
            //ou
            Console.WriteLine("{0} tem {1} anos e tem um saldo de {2:F2}", nome, idade, saldo);
            //ou
            Console.WriteLine($"{nome} tem {idade} nos e {saldo} de saldo");

            // bool completo = false;
            // char genero = 'F';
            // char letra = '\u0041';
            // byte n1 = 126;
            // int n2 = 1000;
            // int n3 = 2147483647;
            // long n4 = 2147483648L;
            // float n5 = 4.5f;
            // double n6 = 4.5;
            // string nome = "Maria Green";
            // object obj1 = "Alex Brown";
            // object obj2 = "4.5f";

            // Console.WriteLine(completo);
            // Console.WriteLine(genero);
            // Console.WriteLine(letra);
            // Console.WriteLine(n1);
            // Console.WriteLine(n2);
            // Console.WriteLine(n3);
            // Console.WriteLine(n4);
            // Console.WriteLine(n5);
            // Console.WriteLine(n6);
            // Console.WriteLine(nome);
            // Console.WriteLine(obj1);
            // Console.WriteLine(obj2);
        }
    }
}