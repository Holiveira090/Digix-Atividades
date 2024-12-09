using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO_ExProdutos
{
    public abstract class Produto
    {
        public int Codigo;
        public double Preco;

        public Produto(int codigo, double preco)
        {
            this.Codigo = codigo;
            this.Preco = preco;
        }
        public abstract void setCodigo(int codigo);
        public abstract void setPreco(double preco);
        public abstract int getCodigo();
        public abstract double getPreco();
        public abstract void atualizarPreco(double preco);

    }
}