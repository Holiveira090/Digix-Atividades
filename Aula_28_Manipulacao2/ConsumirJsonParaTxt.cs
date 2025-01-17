using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Aula_28_Manipulacao2
{
    public class ConsumirJsonParaTxt
    {
        // Url do arquivo Json contendo informações sobre animes
        string url = "https://raw.githubusercontent.com/manami-project/anime-offline-database/master/anime-offline-database-minified.json";

        // Nome do arquivo txt de saida
        string nomeArquivo = "animes.txt";

        public async Task ConsumirJson()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Faz a requisição get para obter o arquivo json
                    var response = await client.GetAsync(url);

                    var responseString = await response.Content.ReadAsStringAsync();
                    // Deixar o Json em estrutura dinamica que é o JsonDocument
                    using (JsonDocument document = JsonDocument.Parse(responseString))
                    {
                        var animeList = document.RootElement.GetProperty("data");

                        // Função grava todas as informações do Json e salva em um arquivo
                        SalvarEmTxt(animeList, nomeArquivo);
                    }

                    System.Console.WriteLine("Informações salvas com sucesso!");
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        static void SalvarEmTxt(JsonElement animeList, string nomeArquivo)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(nomeArquivo))
                {
                    foreach (var anime in animeList.EnumerateArray())
                    {
                        string tittle = anime.GetProperty("title").GetString() ?? "Sem título";
                        string type = anime.GetProperty("type").GetString() ?? "Sem tipo";
                        int episodes = anime.TryGetProperty("episodes", out JsonElement episodesElement) ? episodesElement.GetInt32() : 0;
                        string status = anime.GetProperty("status").GetString() ?? "Sem status";
                        // escreve a temporada do anime
                        string season = "N/A";
                        int year = 0;

                        // if (anime.TryGetProperty("animeSeason", out JsonElement animeSeason))
                        // {
                        //     season = animeSeason.TryGetProperty("season").GetString() ?? "N/A";
                        // }
                        
    
                    }

                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
