using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_27_ManipulacaoArquivoBinario
{
    public class Exemplo2
    {
        // Aqui a gente vai ler o arquivo binario e imprimir no prompt
        static void Exe2(string[] args)
        {
            string filePath = "dados.bin"; // Caminho do arquivo

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {

                int inteiro = reader.ReadInt32(); // Lendo um inteiro com 32 bits
                double numeroReal = reader.ReadDouble();
                string texto = reader.ReadString(); // lendo o string

                System.Console.WriteLine($"Numero int do arquivo: {inteiro}");
                System.Console.WriteLine($"Numero real do arquivo: {numeroReal}");
                System.Console.WriteLine($"Texto do arquivo: {texto}");
            }
        }
    }
}