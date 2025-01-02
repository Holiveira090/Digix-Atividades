using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public class Moto : Veiculo
    {
        private int Cilindrada;

        public Moto(string modelo, float valorLocacaoDiario, int cilindrada = 125)
            : base(modelo, valorLocacaoDiario)
        {
            Cilindrada = cilindrada;
        }

        public override float CalcularValorLocacao()
        {
            return ValorLocacaoDiario + (Cilindrada / 100) * 10;
        }
    }

}