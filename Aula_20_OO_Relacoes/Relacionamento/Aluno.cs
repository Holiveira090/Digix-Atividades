using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes
{
    // Classe Aluno vai ser o fundamental para a escola, então vai ter relação de composição
    public class Aluno
    {
        public string Nome {get; set; }
        public Aluno(string nome)
        {
            Nome = nome;
        }
    }
}