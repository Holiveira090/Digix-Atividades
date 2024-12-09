using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO_ExEmpregado
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Assalariado assalariado = new Assalariado("Tiao", "Do Bar", "9012304210412", 50000);
            assalariado.ImprimirDados();

            Comissionado comissionado = new Comissionado("Eduardo", "da Silva", "131242142123", 1000, 10, 10);
            comissionado.ImprimirDados();

            Horista horista = new Horista("Jao", "Ferreira", "63435476452", 10, 10);
            horista.ImprimirDados();
        }
    }
}