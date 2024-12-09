using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO
{
    public class Circulo : Forma
    {
        public double Raio;

        // Construtor
        public Circulo(string nome, double raio) : base(nome)
        {
            Raio = raio;
        }

        // Metodo para calcular area
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2); // PI * Raio^2
        }

        // Metodo para calcular o perimetro
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

        //Metodo para imprimir os dados
        public override void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Raio: {Raio}");
            System.Console.WriteLine($"Area: {CalcularArea():f2}");
            System.Console.WriteLine($"Perimetro: {CalcularPerimetro():f2}");
        }
    }
}