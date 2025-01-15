using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_26_ManipulacaoArquivos
{
    public class Exemplo1
    {

        static void Exe1()
        { 
        // File é uma classe estatica que contem metodos para manipulação de arquivos
        string inicioParh = @"C:\Users\henriqueoliveira\Desktop\Teste1.txt";

        string finalFile = @"C:\Users\henriqueoliveira\Desktop\Teste2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(inicioParh); // Cria um objeto com referencia endereço criamos do arquivo
        fileInfo.CopyTo(finalFile); // Copia do arquivo de origin para o destino

                // Mostrar oq esta ecrito no arquivo inicioParh
                string[] lines = File.ReadAllLines(inicioParh);
                foreach (string item in lines) // Percorre todas as linhas
                {
                    System.Console.WriteLine(item);
                }
}
            catch (IOException e) // Tratamento especifico para manipular arquivo
            {
                
                System.Console.WriteLine("Ocorreu erro");
System.Console.WriteLine("e.Message");
            }
        }
    }
}