using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public class Animal
    {
        protected int Pernas = 0;
        public Animal(int pernas)
        {
            Pernas = pernas;
        }
        public void caminha()
        {
            System.Console.WriteLine("O animal esta caminhando com {Pernas} pernas");
        }
        public virtual void Come()
        {
            System.Console.WriteLine("O animal está comendo");
        }
    }
}