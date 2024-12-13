using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Aula_18_OO_Encapsulamento
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Teste", 1);
            // p.SetNome("Bomba");
            // Agora vou utilizar a propriedade
            p.Nome = "Bomba nuclear";
            p.Preco = 20000;
            p.Quantidade = 10;
            System.Console.WriteLine($"Nome: {p.Nome}\nPreço: {p.Preco:C2}\nQuantidade: {p.Quantidade}");
            // Imprimir pelo ToString
            System.Console.WriteLine(p.ToString());

            // Algumas funções para validar seus tipos e propriedades
            // A classe type representa o metadados de uma classe em tempo de execução
            Type t = typeof(Produto); // Vai retornar o tipo da classe
            System.Console.WriteLine(t.Name); // Vai retornar o nome da classe

            // Vou mostrar todas as suas propriedades
            System.Console.WriteLine("propriedades: ");
            foreach (PropertyInfo prop in t.GetProperties())
            {
                // O PropertyInfo é uma classe que representa uma propriedade de um tipo
                System.Console.WriteLine(prop.Name);
            }
        }
    }
}