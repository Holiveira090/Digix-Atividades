using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public class CasaTerrea : Casa
{
    public CasaTerrea(float metragemTotal, string endereco, Engenheiro responsavel, List<UnidadeResidencial> unidades, bool condominio)
        : base(metragemTotal, endereco, responsavel, unidades, condominio)
    {
    }
}

}