using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_OO_Encapsulamento
{
    public class Produto
    {
        // private string _nome; // Covenção de nomenclatura do C#: _nome
        // Propriedade automatica
        public string Nome { get; set; }
        private double _preco;
        private int _quantidade;

        // Construtor padrão
        public Produto()
        {
        }

        // Construtor com 2 argumentos
        public Produto(string nome, double preco)
        {
            Nome = nome;
            _preco = preco;
        }

        // Reutilizando construtor dentro de outro construtor
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        // Encapsulamento, que é Get(retornar) e Set(alterar de atributos privados)
        // public string GetNome()
        // {
        //     return _nome;
        // }

        // public void SetNome(string nome)
        // {
        //     if (nome != null && nome.Length > 1)
        //     {
        //         _nome = nome;
        //     }
        // }

        // Agora vou utilizar as propriedades do C# para fazer Get e Set
        // public string Nome
        // {
        //     get { return _nome; }
        //     set
        //     {
        //         if (value != null && value.Length > 1)
        //         {
        //             _nome = value;
        //         }
        //     }
        // }


        // public int GetQuantidade()
        // {
        //     return _quantidade;
        // }

        // public void SetQuantidade(int quantidade)
        // {
        //     _quantidade = quantidade;
        // }

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        // public double GetPreco()
        // {
        //     return _preco;
        // }

        // public void SetPreco(double preco)
        // {
        //     if (preco > 0 && preco < 100000)
        //     {
        //         _preco = preco;
        //     }
        // }

        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value > 0 && value < 100000)
                {
                    _preco = value;
                }
            }
        }

        // Função adicionar quantidade em estoque
        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }

        // Função remover quantidade em estoque
        public void RemoverProduto(int quantidade)
        {
            _quantidade -= quantidade;
        }

        // Atribuir calcular valor total em estoque
        public double ValorTotalemEstoque()
        {
            return _preco * _quantidade;
        }

        // Função ToString
        public override string ToString()
        {
            return $"{Nome}, {_preco.ToString("C2")}, {_quantidade} unidades, Total: {ValorTotalemEstoque().ToString("C2")}";
        }


    }
}