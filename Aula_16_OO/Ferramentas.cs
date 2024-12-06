using System;
namespace Aula_16_OO
{
    // public class Ferramentas
    // {
    //     // public string? Nome;
    //     // public double Preco;
    //     // public int Quantidade;

    //     // // Construtor
    //     // public Ferramentas()
    //     // {
    //     //     // Atribui os valores dos parâmetros aos atributos da classe
    //     //     Nome = null;
    //     //     Preco = 0;
    //     //     Quantidade = 0;
    //     //     // Se instanciar
    //     //     // Ferramentas p = new Ferramentas();
    //     //     //p.Nome = "Coxinha";
    //     // }
    //     // public Ferramentas(string nome, double preco, int quantidade)
    //     // {
    //     //     this.Nome = nome;
    //     //     this.Preco = preco;
    //     //     this.Quantidade = quantidade;
    //     //     // Se instanciar
    //     //     // Ferramentas P = new Ferramentas("Coxinha", 5.00, 10)
    //     // }

    //     public double CalcularEstoque()
    //     {
    //         return (double)Preco * Quantidade; // null * 0 = Erro
    //     }
    //     public string ListarInfo()
    //     {
    //         return $"{Nome}\npreço: {Preco:C}\nQuantidade: {Quantidade}\nPreço final: {CalcularEstoque():C}\n---------------------";
    //     }

    //     


    // }





    
    // Construtor usando record que é uma nova funcionalidade do C# 9
    public record Ferramentas(string nome, double preco, int quantidade)
    {
        public double CalcularEstoque()
        {
            return preco * quantidade; // null * 0 = Erro
        }
        public string ListarInfo()
        {
            return $"{nome}\npreço: {preco:C}\nQuantidade: {quantidade}\nPreço final: {CalcularEstoque():C}\n---------------------";
        }
    }

}