using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25_OO_Struct
{
    public struct PessoaStruct
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public PessoaStruct(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }
    public class PessoaClasse
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public PessoaClasse(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }
    class ExecutarExe
    {
        // public static void Main(string[] args)
        public static void ExecutarExemplo()
        {
            PessoaStruct pessoaStruct = new PessoaStruct("João", 20);
            PessoaStruct pessoaStruct2 = pessoaStruct;
            pessoaStruct2.Nome = "Maria";

            System.Console.WriteLine(pessoaStruct);
            System.Console.WriteLine(pessoaStruct2);

            // Trabalhar com PessoaClasse
            PessoaClasse pessoaClasse = new PessoaClasse("João", 20);
            PessoaClasse pessoaClasse2 = pessoaClasse;
            pessoaClasse2.Nome = "Maria";

            System.Console.WriteLine(pessoaClasse);
            System.Console.WriteLine(pessoaClasse2);

            // Principais diferenças
            // 1. Struct é um tipo de valor, então atribouições criam copias independentes
            // 2. Classe é um tipo de referência, então atribuições criam referências para o mesmo objeto
            //3. Struct são mais leves e geralmente usados para dados simples e imutaveis
            // 4. Classes são mais adequadas para objetos complexos e mutáveis 
        }
    }
}