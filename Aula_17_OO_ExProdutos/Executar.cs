using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO_ExProdutos
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Produto [] produtos = new Produto[3];
            produtos[0] = new Livro(1, 20, "Autor 1", 1234556);
            produtos[1] = new CompactDisc(2, 40, "Artista 1", "Gravadora 1");
            produtos[2] = new Livro(3, 200, "Autor 2", 1234556123);

            foreach (Produto produto in produtos)
            {
                System.Console.WriteLine($"Codigo: {produto.getCodigo()}");
                System.Console.WriteLine($"Preço: {produto.getPreco():C}");
                produto.atualizarPreco(produto.getPreco() * 1.1);
                System.Console.WriteLine($"Preço atualizado: {produto.getPreco():c}");
                System.Console.WriteLine();
            }
        }
    }
}