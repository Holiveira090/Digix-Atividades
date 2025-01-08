using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Selados
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public virtual void Salario(double salario)
        {
            System.Console.WriteLine($"Salario base: {salario}");
        }
        public virtual void Trabalhar()
        {
            System.Console.WriteLine("Trabalhando...");
        }
    }
}