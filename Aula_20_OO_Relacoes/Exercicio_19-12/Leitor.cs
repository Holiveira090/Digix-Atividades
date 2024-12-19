using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes
{
    public class Leitor : Usuario
{
    public Leitor(string nome, string cpf) : base(nome, cpf)
    {
    }
    public void PegarEmprestado(Livro livro)
    {
        System.Console.WriteLine($"{Nome} pegou o livro {livro.Titulo} emprestado");
    }
    public void DevolverLivro(Livro livro)
    {
        System.Console.WriteLine($"{Nome} devolveu o livro {livro.Titulo} emprestado");
    }
    public void ConsultarLivros(CatalogoDeLivros catalogo)
    {
        System.Console.WriteLine("Opções do catalogo:");
        catalogo.ConsultarLivros();
    }
}
}