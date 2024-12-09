using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO_Visibilidade
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Instanciar o objeto funcionario
            Funcionarios funcionario = new Funcionarios("João", 2000, "Analista");
            System.Console.WriteLine($"Funcionario: {funcionario.Nome}");
            funcionario.Nome = "Fulano";
            System.Console.WriteLine($"Funcionario: {funcionario.Nome}");

            // Iniciar objeto Gerente
            Gerente gerente = new Gerente("Maria", 5000);
            gerente.Nome = "Ciclano";
            System.Console.WriteLine($"Gerente: {gerente.Nome}");
            gerente.AtualizarCargoGerente("Diretor");

            gerente.CalcularImpostoGerente(); // * Metodo privado

            
        }
    }
}