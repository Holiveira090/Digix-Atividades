using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public class CasaSobrado : Casa
{
    public int NumAndares { get; set; }
    public CasaSobrado(float metragemTotal, string endereco, Engenheiro responsavel, List<UnidadeResidencial> unidades, bool condominio, int numAndares)
        : base(metragemTotal, endereco, responsavel, unidades, condominio) // Chamada ao construtor base com os parâmetros corretos
    {
        NumAndares = numAndares; 
    }
    public int getNumAndares()
    {
        return NumAndares;
    }
    public void setNumAndares(int nAnd)
    {
        NumAndares = nAnd;
    }
    
    public override string DescricaoDoImovel()
    {
        string unidadesDescricao = string.Join("\n", Unidades.Select((u, index) =>
            $"Unidade {index + 1}\n{u.DescricaoUnidade()}"));

        return $"Condominio: {Condominio}\nSituado a: {Endereco}\nArea Total: {MetragemTotal}\nResponsável: {Responsavel.getNome()}. CREA: {Responsavel.Crea}\nNumero de andares: {NumAndares}\nNumero de casas:\n{unidadesDescricao}";
    }
}

}