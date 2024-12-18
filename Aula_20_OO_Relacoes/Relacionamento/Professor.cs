using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes
{
    // Classe professor, vai ser agregada com a classe Escola, então vai ter relação de agregação
    public class Professor
    {
        public string Nome {get; set; }
        public Professor(string nome)
        {
            Nome = nome;
        }

        public void ensinar()
        {
            System.Console.WriteLine($"Professor: {Nome}");
        }
    }
}