using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public class Familia : Ordem
    {
        public string NomeFamilia;
        public Familia(string nomeReino, string nomeFilo, string nomeClasse, string nomeOrdem, string nomeFamilia) : base(nomeReino, nomeFilo, nomeClasse, nomeOrdem)
        {
            NomeFamilia = nomeFamilia;
        }
        public override string ObterDescricao()
        {
            return $"{base.ObterDescricao()}\nFamilia {NomeFamilia}";
        }
    }
}