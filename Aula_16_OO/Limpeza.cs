using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO
{
    public class Limpeza
    {
       public string? Nome;
        public double Preco;
        public int Quantidade;

        // Construtor
        public Limpeza()
        {
            // Atribui os valores dos parâmetros aos atributos da classe
            Nome = null;
            Preco = 0;
            Quantidade = 0;
            // Se instanciar
            // Limpeza p = new Limpeza();
            //p.Nome = "Coxinha";
        }
        public Limpeza(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
            // Se instanciar
            // Limpeza P = new Limpeza("Coxinha", 5.00, 10)
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