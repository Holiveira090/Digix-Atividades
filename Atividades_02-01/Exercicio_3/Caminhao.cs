using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public class Caminhao : Veiculo
    {
        private int NumEixos;

        public Caminhao(string modelo, float valorLocacaoDiario, int numEixos)
            : base(modelo, valorLocacaoDiario)
        {
            NumEixos = numEixos;
        }

        public override float CalcularValorLocacao()
        {
            return ValorLocacaoDiario + (NumEixos * 50); 
        }
    }

}