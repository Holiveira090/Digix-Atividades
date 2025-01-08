using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Selados
{
    public class Coordenador : Funcionario
    {
        public override void Salario(double salario)
        {
            System.Console.WriteLine($"Salario base: {salario * 1.2}");
        }
        public sealed override void Trabalhar()
        {
            System.Console.WriteLine("Coordenando...");
        }
    }
}