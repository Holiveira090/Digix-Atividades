using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes
{
    public class Biblioteca
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public CatalogoDeLivros Catalogo { get; set; }
        public Biblioteca(string nome, string endereco, CatalogoDeLivros catalogo)
        {
            Nome = nome;
            Endereco = endereco;
            Catalogo = catalogo;
        }
        public void AdicionarCatalogo(CatalogoDeLivros catalogo)
        {
            Catalogo = catalogo;
            Console.WriteLine($"Catálogo {catalogo} adicionado à biblioteca {Nome}");
        }
        public void RemoverCatalogo()
        {
            Catalogo = null;
            Console.WriteLine($"Catálogo removido da biblioteca {Nome}");
        }

    }
}