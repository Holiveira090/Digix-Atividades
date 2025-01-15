using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_27_ManipulacaoArquivoBinario
{
    public class Atividade
    {
        static void Main(string[] args)
        {
            string filePath = "dados.csv";

            var linhas = File.ReadAllLines(filePath); // Isso aqui faz ler todas as linhas do arquivo
            List<string> resultado = new List<string>(); // Essa lista vai armazenar os resultados

            foreach (var linha in linhas)
            {
                // Ignorar linha vazia ou cabeçalho
                if (string.IsNullOrWhiteSpace(linha) || linha.StartsWith("Nome"))
                    continue;

                // Dividir a linha em partes: nome, preço e quantidade
                var colunas = linha.Split(',');

                // Remover espaços extras (se houver)
                string nome = colunas[0].Trim();
                decimal precoUnitario = decimal.Parse(colunas[1].Trim());
                int quantidade = int.Parse(colunas[2].Trim());

                // Calcular o valor total para aquele item
                decimal valorTotal = precoUnitario * quantidade;

                // Adicionar o resultado à lista
                resultado.Add($"{nome},{valorTotal:F2}");
            }
            string outputFolder = Path.Combine(Directory.GetCurrentDirectory(), "out");
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }

            // Caminho do arquivo de saída
            string outputFilePath = Path.Combine(outputFolder, "summary.csv");

            // Escrever os resultados no arquivo "summary.csv"
            File.WriteAllLines(outputFilePath, resultado);

            // Informar ao usuário que o arquivo foi gerado
            Console.WriteLine($"Arquivo summary.csv gerado em: {outputFilePath}");


        }
    }
}