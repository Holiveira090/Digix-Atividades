using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Animal
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Cobra cobra = new Cobra(true, false);
            cobra.Alimento("Rato");
            cobra.SetVenenosa(true);
            System.Console.WriteLine("-------------------");
            
            Javali javali = new Javali(true, true);
            javali.SetSelvagem(true);
            if (javali.SetSelvagem(true))
            {
                System.Console.WriteLine("O javali é selvagem");
            }
            else
            {
                System.Console.WriteLine("O javali não é selvagem");
            }
            System.Console.WriteLine($"A velocidade maximo do javali é {javali.GetVelocidadeMaxima()} km/h");

        }
    }
}