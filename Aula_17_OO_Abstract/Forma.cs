using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO
{
    public abstract class Forma
    {
        public string Nome;

        // Construtor

        public Forma(string nome)
        {
            Nome = nome;
        }

        // Metodo para calcular area
        // Metodos abstratos não possuem corpo e devem ser implementados nas classes filhas
        public abstract double CalcularArea();

        // metodo calcular perimetro
        public abstract double CalcularPerimetro();

        // Metodo para imprimir dados
        public virtual void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Area: {CalcularArea()}");
            System.Console.WriteLine($"Perimetro: {CalcularPerimetro()}");
        }
    }
}