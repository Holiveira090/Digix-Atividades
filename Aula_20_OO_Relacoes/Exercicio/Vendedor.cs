// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_20_OO_Relacoes
// {
//     public class Vendedor : Funcionario
//     {
//         public EquipeVenda Equipe { get; set; }
//         public Vendedor(string nome, DateTime nascimento, string cpf, Endereco endereco, EquipeVenda equipe) : base(nome, nascimento, cpf, endereco)
//         {
//             Equipe = equipe;
//         }
//         public override string getNome()
//         {
//             return Nome;
//         }
//         public override DateTime getNascimento()
//         {
//             return Nascimento;
//         }
//         public override string getCPF()
//         {
//             return CPF;
//         }
//         public override Endereco GetEndereco()
//         {
//             return Endereco;
//         }
//         public float getSalario()
//         {
//             return 5000;
//         }
//     }
// }