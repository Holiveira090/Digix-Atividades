using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public class Peixe : Animal, IAnimalDeEstimacao
    {
        public string Nome { get; set; }
        
        public Peixe(int pernas, string nome) : base(pernas)
        {
            Nome = nome;
        }
        public string getNome()
        {
            return Nome;
        }
        public void setNome(string nome)
        {
            Nome = nome;
        }
        public void Brinca()
        {
            System.Console.WriteLine("Não brinca");
        }
        public override void Come()
        {
            System.Console.WriteLine("O peixe esta comendo ração");
        }
    }
}