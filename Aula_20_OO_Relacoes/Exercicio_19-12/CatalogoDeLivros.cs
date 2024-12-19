using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes
{
    public class CatalogoDeLivros
    {
        public List<Livro> ListaDeLivros { get; set; }
        public CatalogoDeLivros(List<Livro> listaDeLivros)
        {
            ListaDeLivros = listaDeLivros;
        }
        public void ConsultarLivros()
        {
            if (ListaDeLivros.Count == 0)
            {
                Console.WriteLine("Nenhum livro disponível no catálogo.");
                return;
            }

            foreach (var livro in ListaDeLivros)
            {
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Exemplares disponíveis: {livro.NumeroExemplares}");
            }
        }
    }
}