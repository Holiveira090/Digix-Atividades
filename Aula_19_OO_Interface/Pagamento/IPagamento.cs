using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public interface IPagamento
    {
        void RealizarPagamento(double valor); // Isso é implicitamente publico e abstrato
        void ExibirCompravante(); // Isso é implicitamente publico e abstrato
        
    }
}