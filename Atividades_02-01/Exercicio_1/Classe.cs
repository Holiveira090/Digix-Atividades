using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public class Classe : Filo
    {
        public string NomeClasse;

        public Classe(string nomeReino, string nomeFilo, string nomeClasse) : base(nomeReino, nomeFilo)
        {
            NomeClasse = nomeClasse;
        }
        public override string ObterDescricao()
        {
            return $"{base.ObterDescricao()}\nClasse {NomeClasse}";
        }
    }
    
}