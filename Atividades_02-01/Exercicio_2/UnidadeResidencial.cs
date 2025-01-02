using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public class UnidadeResidencial
    {
        protected float MetragemUnidade;
        protected int NumQuartos;
        protected int NumBanheiros;
        protected Pessoa Proprietario;
        public UnidadeResidencial(float metragemUnidade, int numQuartos, int numBanheiros, Pessoa proprietario)
        {
            MetragemUnidade = metragemUnidade;
            NumQuartos = numQuartos;
            NumBanheiros = numBanheiros;
            Proprietario = proprietario;
        }
        public float getMetragemUnidade()
        {
            return MetragemUnidade;
        }
        public void setMetragemUnidade(float metragem)
        {
            MetragemUnidade = metragem;
        }
        public float getNumQuartos()
        {
            return NumQuartos;
        }
        public void setNumQuartos(int nQuartos)
        {
            NumQuartos = nQuartos;
        }
        public float getNumBanheiros()
        {
            return NumBanheiros;
        }
        public void setNumBanheiros(int nBan)
        {
            NumBanheiros = nBan;
        }
        public Pessoa getProprietario()
        {
            return Proprietario;
        }
        public void setProprietario(Pessoa prop)
        {
            Proprietario = prop;
        }
        public string DescricaoUnidade()
        {
            return $"Propriedade de {Proprietario.getNome()}. Possui {MetragemUnidade} metros quadrados, {NumQuartos} quartos, {NumBanheiros} banheiros.";
        }


    }
}