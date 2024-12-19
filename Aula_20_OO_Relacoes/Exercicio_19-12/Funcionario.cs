using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes
{
    public class Funcionario : Usuario
    {
        public string Cargo { get; set; }
        public CatalogoDeLivros Catalogo { get; set; }
        public Funcionario(string nome, string cpf, string cargo, CatalogoDeLivros catalogo) : base(nome, cpf)
        {
            Cargo = cargo;
            Catalogo = catalogo;
        }
        public void AdicionarLivro(Livro livro)
        {
            Catalogo.ListaDeLivros.Add(livro);
            Console.WriteLine($"Funcionário {Cargo} adicionou o livro {livro.Titulo} ao catálogo.");
        }
        public void RemoverLivro(Livro livro)
        {
            Catalogo.ListaDeLivros.Remove(livro);
            Console.WriteLine($"Funcionário {Cargo} removeu o livro {livro.Titulo} do catálogo.");
        }
        public void RealizarEmprestimo(Livro livro)
        {
            System.Console.WriteLine($"Funcionário {Cargo} emprestou o livro {livro.Titulo} do catálogo.");
        }
    }
}