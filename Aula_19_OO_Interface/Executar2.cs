using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public class Executar2
    {
        static void Main(string[] args)
        {
            Peixe peixe = new Peixe(0, "Dourado");
            peixe.Come();
            peixe.Brinca();
            peixe.setNome("teste");
            System.Console.WriteLine(peixe.getNome());
            System.Console.WriteLine("---------------------------------------------------------");

            Cachorro cachorro = new Cachorro(4, "Scooby");
            System.Console.WriteLine(cachorro.getNome());
            cachorro.setNome("Jão");
            System.Console.WriteLine(cachorro.getNome());
            cachorro.Brinca();
            cachorro.Come();
        }
    }
}