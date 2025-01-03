using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02_01
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Especie especie = new Especie(
               "Animalia",    // Reino
               "Chordata",    // Filo
               "Mammalia",    // Classe
               "Primata",     // Ordem
               "Hominidae",   // Família
               "Homo",        // Gênero
               "Homo sapiens" // Espécie
           );
            Especie especie2 = new Especie(
                "Animalia",    // Reino
                "Chordata",    // Filo
                "Mammalia",    // Classe
                "Carnívora",     // Ordem
                "Canidae",   // Família
                "Canis",        // Gênero
                "Canis samiliaris" // Espécie
            );
            Especie especie3 = new Especie(
                "Animalia",    // Reino
                "Arthropoda",    // Filo
                "Insecta",    // Classe
                "Díptera",     // Ordem
                "Muscidae",   // Família
                "Musca",        // Gênero
                "Musca domestica" // Espécie
            );

            // Exibindo toda a taxonomia
            System.Console.WriteLine("Humano:\n");
            Console.WriteLine($"{especie.ObterDescricao()}\n\n");
            System.Console.WriteLine("Cachorro:\n");
            Console.WriteLine($"{especie2.ObterDescricao()}\n\n");
            System.Console.WriteLine("Mosca:\n");
            Console.WriteLine($"{especie3.ObterDescricao()}\n\n");
        }
    }
}