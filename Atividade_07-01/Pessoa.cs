using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_07_01
{
    public class Pessoa
    {
        protected string Nome { get; set; }
        public Pessoa()
        {
        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public void setNome(string nome)
        {
            Nome = nome;
        }
        public string getNome()
        {
            return Nome;
        }
    }
}