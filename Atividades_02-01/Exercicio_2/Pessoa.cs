using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public class Pessoa
    {
        protected string Nome;
        protected string Cpf;
        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
        public string getNome()
        {
            return Nome;
        }
        public void setNome(string nome)
        {
            Nome = nome;
        }
        public string getCPF()
        {
            return Cpf;
        }
        public void setCPF(string cpf)
        {
            Cpf = cpf;
        }


    }
}