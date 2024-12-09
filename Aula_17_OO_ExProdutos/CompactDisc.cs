using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO_ExProdutos
{
    public class CompactDisc : Produto
    {
        public string Artista;
        public string Gravadora;

        public CompactDisc(int codigo, double preco, string artista, string gravadora) : base(codigo, preco)
        {
            this.Artista = artista;
            this.Gravadora = gravadora;
        }
        public void setArtista(string Artista)
        {
            this.Artista = Artista;
        }
        public void setGravadora(string Gravadora)
        {
            this.Gravadora = Gravadora;
        }
        public string getArtista()
        {
            return Artista;
        }
        public string getGravadora()
        {
            return Gravadora;
        }
        public override void atualizarPreco(double preco)
        {
            this.Preco = preco;
        }
        public void ExibirInfo()
        {
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Preço: {Preco:C}");
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Gravadora: {Gravadora}");
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
    }
}