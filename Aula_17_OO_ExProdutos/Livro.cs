using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO_ExProdutos
{
    public class Livro : Produto
    {
        public string Autor;
        public long ISBN;

        public Livro(int codigo, double preco, string autor, long isbn) : base(codigo, preco)
        {
            Autor = autor;
            ISBN = isbn;
        }
        public override void setCodigo(int codigo)
        {
            Codigo = codigo;
        }
        public override void setPreco(double preco)
        {
            Preco = preco;
        }
        public override int getCodigo()
        {
            return Codigo;
        }
        public override double getPreco()
        {
            return Preco;
        }
        public override void atualizarPreco(double preco)
        {
            Preco = preco;
        }
        public void ExibirInfo()
        {
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Preço: {Preco:C}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
}