using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public abstract class Reino
    {
        public string NomeReino;

        public Reino(string nomeReino)
        {
            NomeReino = nomeReino;
        }
        public abstract string ObterDescricao();
    }
}