using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public abstract class Veiculo
    {
        protected string Modelo;
        protected float ValorLocacaoDiario;

        public Veiculo(string modelo, float valorLocacaoDiario)
        {
            Modelo = modelo;
            ValorLocacaoDiario = valorLocacaoDiario;
        }

        public abstract float CalcularValorLocacao();
    }

}