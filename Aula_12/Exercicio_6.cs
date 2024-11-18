using System;

namespace Exercicio_6
{
    class Exercicio_6
    {
        // Função para calcular a média de um aluno
        static double CalcularMedia(string aluno)
        {
            string[] partes = aluno.Split(',');  // Divide a string pelo delimitador ','
            int soma = 0;
            int numNotas = partes.Length - 1;  // Exclui o nome do aluno

            for (int i = 1; i < partes.Length; i++)  // Soma as notas
            {
                soma += int.Parse(partes[i].Trim());  // Converte e soma as notas
            }

            return soma / (double)numNotas;  // Calcula e retorna a média
        }

        // Algoritmo Insertion Sort para ordenar os alunos pela média em ordem decrescente
        static void OrdenarPorMedia(ref string[] alunos, ref double[] medias)
        {
            for (int i = 1; i < alunos.Length; i++)
            {
                string alunoAtual = alunos[i];
                double mediaAtual = medias[i];
                int j = i - 1;

                // Move os elementos menores que a média atual para a direita
                while (j >= 0 && medias[j] < mediaAtual)
                {
                    alunos[j + 1] = alunos[j];
                    medias[j + 1] = medias[j];
                    j--;
                }

                // Coloca o aluno e a média na posição correta
                alunos[j + 1] = alunoAtual;
                medias[j + 1] = mediaAtual;
            }
        }

        // Algoritmo Bubble Sort para ordenar alfabeticamente os alunos em caso de empate nas médias
        static void OrdenarPorNome(ref string[] alunos, ref double[] medias)
        {
            for (int i = 0; i < alunos.Length - 1; i++)
            {
                for (int j = 0; j < alunos.Length - i - 1; j++)
                {
                    // Caso de empate na média, ordena alfabeticamente pelo nome
                    if (medias[j] == medias[j + 1] && string.Compare(alunos[j], alunos[j + 1]) > 0)
                    {
                        string tempAluno = alunos[j];
                        double tempMedia = medias[j];
                        alunos[j] = alunos[j + 1];
                        medias[j] = medias[j + 1];
                        alunos[j + 1] = tempAluno;
                        medias[j + 1] = tempMedia;
                    }
                }
            }
        }

        // Função para imprimir os alunos e suas médias
        static void Imprimir(string[] alunos, double[] medias)
        {
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine($"{alunos[i]}: {medias[i]:F1}");  // Exibe o nome do aluno e a média com uma casa decimal
            }
        }

        static void Main(string[] args)
        {
            // Lista de alunos com suas notas
            string[] alunos = { "Ana, 7, 8, 9", "Carlos, 10, 9, 8", "Beatriz, 6, 7, 8", "Will, 10, 9, 8" };

            // Vetor para armazenar as médias dos alunos
            double[] medias = new double[alunos.Length];

            // Calculando a média de cada aluno
            for (int i = 0; i < alunos.Length; i++)
            {
                medias[i] = CalcularMedia(alunos[i]);
            }

            // Ordena os alunos pela média em ordem decrescente
            OrdenarPorMedia(ref alunos, ref medias);

            // Ordena alfabeticamente os alunos com a mesma média
            OrdenarPorNome(ref alunos, ref medias);

            // Imprime os alunos ordenados e suas médias
            Imprimir(alunos, medias);
        }
    }
}
