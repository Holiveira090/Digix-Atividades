using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Animal
{
    public class Javali : Animal
    {
        public bool Selvagem;
        
         public Javali(bool selvagem, bool Vivo) : base(Vivo)
        {
            this.Selvagem = selvagem;
        }  
        
        public int GetVelocidadeMaxima()
        {
            return 40;
        }
        public bool SetSelvagem(bool s)
        {
            return s;
        }
    }
}