using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes
{
    public class RedeDeBibliotecas
    {
        public List<Biblioteca> ListadeBibliotecas { get; set; }
        public List<Funcionario> ListaFuncionarios { get; set; }
        public RedeDeBibliotecas(List<Biblioteca> listadeBibliotecas, List<Funcionario> listaFuncionarios)
        {
            ListadeBibliotecas = listadeBibliotecas;
            ListaFuncionarios = listaFuncionarios;
        }
        public void AdicionarBiblioteca(Biblioteca biblioteca)
        {
            ListadeBibliotecas.Add(biblioteca);
            System.Console.WriteLine($"Biblioteca {biblioteca.Nome} adicionada a Rede.");
        }
        public void RemoverBiblioteca(Biblioteca biblioteca)
        {
            ListadeBibliotecas.Remove(biblioteca);
            System.Console.WriteLine($"Biblioteca {biblioteca.Nome} removida a Rede.");
        }
        public void AdicionarFuncionarios(Funcionario funcionario)
        {
            ListaFuncionarios.Add(funcionario);
            System.Console.WriteLine($"Funcionario {funcionario.Nome} adicionado a biblioteca");
        }
        public void RemoverFuncionarios(Funcionario funcionario)
        {
            ListaFuncionarios.Remove(funcionario);
            System.Console.WriteLine($"Funcionario {funcionario.Nome} removido da biblioteca");
        }

    }
}