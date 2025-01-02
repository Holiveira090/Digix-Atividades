using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public abstract class Edificacao
    {
        protected float MetragemTotal;
        protected string Endereco;
        protected Engenheiro Responsavel;
        protected List<UnidadeResidencial> Unidades;
        public Edificacao(float metragemTotal, string endereco, Engenheiro responsavel, List<UnidadeResidencial> unidades)
        {
            MetragemTotal = metragemTotal;
            Endereco = endereco;
            Responsavel = responsavel;
            Unidades = unidades;
        }
        public float getMetragemTotal()
        {
            return MetragemTotal;
        }
        public void setMetragemTotal(float met)
        {
            MetragemTotal = met;
        }
        public string getEndereco()
        {
            return Endereco;
        }
        public void setEndereco(string end)
        {
            Endereco = end;
        }
        public Engenheiro getResponsavel()
        {
            return Responsavel;
        }
        public void setResponsavel(Engenheiro eng)
        {
            Responsavel = eng;
        }
        public List<UnidadeResidencial> getUnidades()
        {
            return Unidades;
        }
        public void CadastrarUnidade(List<UnidadeResidencial> novaunid)
        {
            Unidades = novaunid;
        }
        public abstract string DescricaoDoImovel();

    }
}