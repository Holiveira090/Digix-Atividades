using System;
namespace Tipagem
{
    internal class Tipagem
    {
        static void Main(String[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine(a.GetType());
            //tipagem implicita
            var c = 10;
            Console.WriteLine(c);
            Console.WriteLine(c.GetType());
            //Tipos de variaveis
            //Array
            int[] d = new int[5];
            Console.WriteLine(d.GetType());
            //Listas
            List<int> e = new List<int>();
            Console.WriteLine(e);
            Console.WriteLine(e.GetType());
            //Dicionarios
            Dictionary<int, string> f = new Dictionary<int, string>();
            Console.WriteLine(f);
            Console.WriteLine(f.GetType());
            //Tuplas
            Tuple<int, string> g = new Tuple<int, string>(1, "teste");
            Console.WriteLine(g);
            Console.WriteLine(g.GetType());
            //



        }
    }
}