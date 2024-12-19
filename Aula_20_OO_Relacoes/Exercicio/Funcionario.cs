// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_20_OO_Relacoes
// {
//     public class Funcionario
//     {
//         public string Nome { get; set; }
//         public DateTime Nascimento { get; set; }
//         public string CPF { get; set; }
//         public Endereco Endereco;
//         public Funcionario(string nome, DateTime nascimento, string cpf, Endereco endereco)
//         {
//             Nome = nome;
//             Nascimento = nascimento;
//             CPF = cpf;
//             Endereco = endereco;
//         }
//         public virtual string getNome()
//         {
//             return Nome;
//         }
//         public virtual DateTime getNascimento()
//         {
//             return Nascimento;
//         }
//         public virtual string getCPF()
//         {
//             return CPF;
//         }
//         public virtual Endereco GetEndereco()
//         {
//             return Endereco;
//         }
//     }
// }