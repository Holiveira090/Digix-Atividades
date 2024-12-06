using System;
namespace Aula_16_OO
{
    public class Carnes
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;

        // Construtor
        public Carnes()
        {
            // Atribui os valores dos parâmetros aos atributos da classe
            Nome = null;
            Preco = 0;
            Quantidade = 0;
            // Se instanciar
            // Carnes p = new Carnes();
            //p.Nome = "Coxinha";
        }
        public Carnes(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
            // Se instanciar
            // Carnes P = new Carnes("Coxinha", 5.00, 10)
        }
        public double CalcularEstoque()
        {
            return (double)Preco * Quantidade; // null * 0 = Erro
        }
        public string ListarInfo()
        {
            return $"{Nome}\npreço: {Preco:C}\nQuantidade: {Quantidade}\nPreço final: {CalcularEstoque():C}\n---------------------";
        }
    }
}