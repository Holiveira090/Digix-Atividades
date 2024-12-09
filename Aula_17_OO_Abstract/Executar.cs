using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_17_OO;

namespace Aula_17_OO_Abstract
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Só poderá instanciar as classes filhas
            Circulo circulo = new Circulo("Circulo", 5);
            circulo.CalcularArea();
            circulo.CalcularPerimetro();
            circulo.ImprimirDados();
        }
    }
}