using System;

namespace ProdutoNamespace
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        // Construtor
        public Produto(string nome, double preco)
        {
            // Atribui os valores dos parâmetros aos atributos da classe
            this.Nome = nome;
            this.Preco = preco;
        }
        
        public Produto()
        {
            // Atribui os valores dos parâmetros aos atributos da classe
            this.Nome = "";
            this.Preco = 2;
        }

        // Método para exibir as informações
        public void ExibirInformações()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Preço: {this.Preco:C}");  // A formatação ":C" exibe o preço como moeda
        }
        
        static void Main(string[] args)
        {
            Produto p1 = new Produto("Notebook", 2000);
            p1.ExibirInformações();
            Produto p2 = new Produto();
            p2.Nome = "Celular";
            p2.Preco = 10000;
            p2.ExibirInformações();
        }
    }
}
