using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public class Genero : Familia
    {
        public string NomeGenero;
        public Genero(string nomeReino, string nomeFilo, string nomeClasse, string nomeOrdem, string nomeFamilia, string nomeGenero) : base(nomeReino, nomeFilo, nomeClasse, nomeOrdem, nomeFamilia)
        {
            NomeGenero = nomeGenero;
        }
        public override string ObterDescricao()
        {
            return $"{base.ObterDescricao()}\nGenero {NomeGenero}";
        }
    }
}