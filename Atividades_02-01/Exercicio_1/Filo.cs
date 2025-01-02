using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public class Filo : Reino
    {
        public string NomeFilo;

        public Filo(string nomeReino, string nomeFilo) : base(nomeReino)
        {
            NomeFilo = nomeFilo;
        }
        public override string ObterDescricao()
        {
            return $"Reino {NomeReino}\nFilo {NomeFilo}";
        }
    }
}