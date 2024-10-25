using System;

namespace Aula_2
{
    class Program
    {
        static void teste()
        {
            //Operadores Aritimeticos
            // int a = 20;
            // int b = 3;

            // // Console.WriteLine(a+b); //Adição
            // // Console.WriteLine(a-b); //Subtração
            // // Console.WriteLine(a*b); //Multiplicação
            // // Console.WriteLine(a/b); //Divisão
            // // Console.WriteLine(a%b); //Resto da divisão
            // //Atribuição aritimetica
            // int c = 10;
            // int d = 5;

            // // System.Console.WriteLine(c += d);  //Adição
            // // System.Console.WriteLine(c -= d);  //Subtração
            // // System.Console.WriteLine(c *= d);  //Multiplicação
            // // System.Console.WriteLine(c /= d);  //Divisão
            // // System.Console.WriteLine(c %= d);  //Resto da divisão

            // //Operadores de Comparação
            // int x = 10;
            // int y = 5;

            // // Console.WriteLine(x == y); //Igualdade
            // // Console.WriteLine(x != y); //Diferente
            // // Console.WriteLine(x > y); //Maior que
            // // Console.WriteLine(x >= y); //Maior ou igual a
            // // Console.WriteLine(x < y); //Menor que
            // // Console.WriteLine(x <= y); //Menor ou igual a

            // //Operadores Logicos
            // bool w = true;
            // bool z = false;

            // Console.WriteLine(w && z); //E
            // Console.WriteLine(w || z); //Ou
            // Console.WriteLine(!w); //Negação
            // System.Console.WriteLine(!z && w) && (z || w);

            // //Operadores de incremento e decremento
            // int i = 10;
            // Console.WriteLine(++i); //incremento
            // Console.WriteLine(--i); //decremento

            //operadores bitwise
            int j = 10; // 1010
            int k = 5; // 0101

            Console.WriteLine(j & k); //AND
            Console.WriteLine(j | k); //OR
            Console.WriteLine(j ^ k); //XOR
            Console.WriteLine(~j); //NOT
            Console.WriteLine(j << 2); //Deslocamento para esquerda
            Console.WriteLine(j >> 2); //Deslocamento para direita
        }
    }
}