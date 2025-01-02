using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public class Casa : Edificacao
    {
        protected bool Condominio;
        public Casa(float metragemTotal, string endereco, Engenheiro responsavel, List<UnidadeResidencial> unidades, bool condominio)
        : base(metragemTotal, endereco, responsavel, unidades)
        {
            Condominio = condominio;
        }
        public bool getCondominio()
        {
            return Condominio;
        }
        public void setCondominio(bool cond)
        {
            Condominio = cond;
        }
        public override string DescricaoDoImovel()
        {
            string unidadesDescricao = string.Join("\n", Unidades.Select((u, index) =>
                $"Unidade {index + 1}\n{u.DescricaoUnidade()}"));

            return $"Condominio: {Condominio}\nSituado a: {Endereco}\nArea Total: {MetragemTotal}\nResponsável: {Responsavel.getNome()}. CREA: {Responsavel.Crea}\nNumero de casas:\n{unidadesDescricao}";
        }

    }
}