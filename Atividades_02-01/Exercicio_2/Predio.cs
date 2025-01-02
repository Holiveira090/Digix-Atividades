using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public class Predio : Edificacao
{
    public string Nome { get; set; }
    public int NumAndares { get; set; }
    public int ApPorAndar { get; set; }

    public Predio(float metragemTotal, string endereco, Engenheiro responsavel, List<UnidadeResidencial> unidades, string nome, int numAndares, int apPorAndar)
        : base(metragemTotal, endereco, responsavel, unidades)
    {
        Nome = nome;
        NumAndares = numAndares;
        ApPorAndar = apPorAndar;
    }

    public override string DescricaoDoImovel()
    {
        string unidadesDescricao = string.Join("\n", Unidades.Select((u, index) => 
            $"Unidade {index + 1}\n{u.DescricaoUnidade()}"));

        return $"Predio: {Nome}\nSituado a: {Endereco}\nArea Total: {MetragemTotal}\nResponsável: {Responsavel.getNome()}. CREA: {Responsavel.Crea}\nNumero de apartamentos por andar:\n{unidadesDescricao}";
    }
}


}