using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Selados
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            f1.Salario(1000);
            f1.Trabalhar();

            Coordenador c1 = new Coordenador();
            c1.Salario(1000);
            c1.Trabalhar();

            Gerente g1 = new Gerente();
            g1.Salario(1000);
            g1.Trabalhar();
        }
    }
}