using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, DateTime nascimento, string cpf, Endereco endereco) : base(nome, nascimento, cpf, endereco)
        {
        }
        public override string getNome()
        {
            return Nome;
        }
        public override DateTime getNascimento()
        {
            return Nascimento;
        }
        public override string getCPF()
        {
            return CPF;
        }
        public override Endereco GetEndereco()
        {
            return Endereco;
        }
        public void getSalario()
        {
            System.Console.WriteLine(10000);
        }
    }
}