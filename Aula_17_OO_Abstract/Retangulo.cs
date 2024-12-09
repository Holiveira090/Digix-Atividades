using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO
{
    public class Retangulo : Forma
    {
        public double Largura;
        public double Altura;

        // Construtor
        public Retangulo(string nome, double largura, double altura) : base(nome)
        {
            this.Largura = largura; // this é opcional porque esta apontando a um atributo da classe global
            this.Altura = altura;
        }
        // Metodo calcular area
        public override double CalcularArea()
        {
            return Largura * Altura;
        }
        public override double CalcularPerimetro()
        {
            return 2 * (Largura * Altura);
        }
        public override void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Largura: {Largura}");
            System.Console.WriteLine($"Altura: {Altura}");
            System.Console.WriteLine($"Area: {CalcularArea()}");
            System.Console.WriteLine($"Perimetro: {CalcularPerimetro()}");
        }
    }
}