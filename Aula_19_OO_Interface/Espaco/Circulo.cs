using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public class Circulo : IForma
    {
        // Propriedades Raio
        public double Raio { get; set; }
        // Construtor
        public Circulo(double raio)
        {
            Raio = raio;
        }

        // Implementação do método CalcularArea
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }
        public void ExibirInformacoes()
        {
            System.Console.WriteLine("Cículo");
            System.Console.WriteLine($"Raio: {Raio}");
        }
    }
}