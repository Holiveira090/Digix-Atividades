using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public class Utilitario : Veiculo
    {
        private string Tipo; 

        public Utilitario(string modelo, float valorLocacaoDiario, string tipo)
            : base(modelo, valorLocacaoDiario)
        {
            Tipo = tipo;
        }

        public override float CalcularValorLocacao()
        {
            
            if (Tipo.ToUpper() == "FURGÃO")
                return ValorLocacaoDiario + 40; 
            else
                return ValorLocacaoDiario; 
        }
    }

}