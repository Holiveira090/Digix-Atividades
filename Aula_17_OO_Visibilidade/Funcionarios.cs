using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO_Visibilidade
{
    public class Funcionarios
    {
        // atributo publico: acessivel de qualquer lugar
        public string Nome;
        // Atributo Privado: acessivel apenas dentro da classe
        private double Salario;

        // Atributo Protegido: acessivel apenas dentro de sua classe e suas subclasses
        protected string Cargo;

        public Funcionarios(string Nome, double Salario, string Cargo)
        {
            this.Nome = Nome;
            this.Salario = Salario;
            this.Cargo = Cargo;
        }
        // Metodo publico: acessivel de qualquer lugar
        public void ExibirInformacoes()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            // System.Console.WriteLine($"Salario: {Salario}"); // * Acessando atributo privado
            System.Console.WriteLine($"Cargo: {Cargo}");
        }
        // Metodo protegido: acessivel apenas dentro da classe e suas subclasses
        protected void AtualizarCargo(string novoCargo)
        {
            Cargo = novoCargo;
            System.Console.WriteLine($"Cargo atualizado para {Cargo}");
        }
        // Metodo privado: acessivel apenas dentro da classe
        private double CalcularImposto()
        {
            return Salario * 0.1; // 10%
        }

    }
}