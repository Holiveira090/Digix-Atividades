using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_27_ManipulacaoArquivoBinario
{
    public class Exemplo1
    {
        // Aqui foi gerado o arquivo binario
        static void Exe2(string[] args)
        {
            string filePath = "dados.bin"; // Caminho do arquivo

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {

                writer.Write(123); // Colocando o valor 123 no arquivo
                writer.Write(45.3546);
                writer.Write("Hello World"); 
            }

            System.Console.WriteLine($"Dados gravados no {filePath}");
        }
    }
}