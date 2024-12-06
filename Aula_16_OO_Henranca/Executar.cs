using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Henranca
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Instanciando um objeto do tipo Gerente
            Gerente gerente = new Gerente("João", "123.456.789-00", 5000, "TI");
            gerente.ImprimirDados();
            gerente.GerenciarEquipes();
            System.Console.WriteLine("-------------------------------");
            Secretaria secretaria = new Secretaria("Joana", "123.456.789-11", 2000, "Secretaria do Gerente");
            secretaria.ImprimirDados();
            secretaria.AtenderTelefone();
            System.Console.WriteLine("-------------------------------");
            Telefonista telefonista = new Telefonista("Alberto", "123.456.789-22", 2500, "Atendente de TI");
            telefonista.ImprimirDados();
            telefonista.AtenderTelefone();
            System.Console.WriteLine("-------------------------------");
        }
    }
}