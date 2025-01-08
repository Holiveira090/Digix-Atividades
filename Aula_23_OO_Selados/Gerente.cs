using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Selados
{
    public sealed class Gerente : Funcionario
    // Selead é quando não pode ser herdado
    {
        public override void Salario(double salario)
        {
            System.Console.WriteLine($"Salario base: {salario * 1.5}");
        }
        public override void Trabalhar()
        {
            System.Console.WriteLine("Gerenciando...");
        }
    }
}