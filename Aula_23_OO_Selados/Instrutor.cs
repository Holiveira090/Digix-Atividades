using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Selados
{
    public class Instrutor : Coordenador
    {
        public override void Salario(double salario)
        {
            System.Console.WriteLine($"Salario base: {salario * 1.3}");
        }

        // não pode herdar por causa do sealed
        // public override void Trabalhar()
        // {
        //     System.Console.WriteLine("Instrutorando...");
        // }
    }
}