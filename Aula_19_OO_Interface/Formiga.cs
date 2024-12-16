using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public class Formiga : Animal
    {
        public Formiga() : base(6)
        {
        }
        public void Caminha()
        {
            System.Console.WriteLine("A formiga caminha em {Pernas} pernas");
        }
        public override void Come()
        {
            System.Console.WriteLine("A formiga está comendo folhas");
        }
    }
}