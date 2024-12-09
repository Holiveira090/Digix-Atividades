using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO_Visibilidade
{
    public class Gerente : Funcionarios
    {
        // Construtor
        public Gerente(string Nome, double Salario) : base(Nome, Salario, "Gerente")
        {

        }
        // Chamando metodo publico da classe base
        public void Imprimir()
        {
            ExibirInformacoes();
        }

        // Chamar metodo protegido da classe base
        public void AtualizarCargoGerente(string novoCargo)
        {
            AtualizarCargo(novoCargo);
        }

        // chamar metodo privado da classe base
        public void CalcularImpostoGerente()
        {
            //System.Console.WriteLine(CalcularImposto()); // não da pq é private
        }
    }
}