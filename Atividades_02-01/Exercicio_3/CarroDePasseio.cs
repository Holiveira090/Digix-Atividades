using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public class CarroDePasseio : Veiculo
    {
        private string Categoria;

        public CarroDePasseio(string modelo, float valorLocacaoDiario, string categoria)
            : base(modelo, valorLocacaoDiario)
        {
            Categoria = categoria;
        }

        public override float CalcularValorLocacao()
        {
            switch (Categoria.ToUpper())
            {
                case "A":
                    return ValorLocacaoDiario - 20;
                case "B":
                    return ValorLocacaoDiario;
                case "C":
                    return ValorLocacaoDiario + 30;
                default:
                    return ValorLocacaoDiario;
            }
        }
    }

}