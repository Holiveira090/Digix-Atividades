using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public class Ordem : Classe
    {
        public string NomeOrdem;
        public Ordem(string nomeReino, string nomeFilo, string nomeClasse, string nomeOrdem) : base(nomeReino, nomeFilo, nomeClasse)
        {
            NomeOrdem = nomeOrdem;
        }
        public override string ObterDescricao()
        {
            return $"{base.ObterDescricao()}\nOrdem {NomeOrdem}";
        }
    }
}