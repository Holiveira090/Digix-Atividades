using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public class Especie : Genero
    {
        public string NomeEspecie;
        public Especie(string nomeReino, string nomeFilo, string nomeClasse, string nomeOrdem, string nomeFamilia, string nomeGenero, string nomeEspecie) : base(nomeReino, nomeFilo, nomeClasse, nomeOrdem, nomeFamilia, nomeGenero)
        {
            NomeEspecie = nomeEspecie;
        }
        public override string ObterDescricao()
        {
            return $"{base.ObterDescricao()}\nEpecie {NomeEspecie}";
        }
    }
}