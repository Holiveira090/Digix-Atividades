using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Aula_26_ManipulacaoArquivos
{
    public class Exemplo5
    {
        static void Exe5()
        {
            string path = @"C:\Users\henriqueoliveira\Desktop\Teste";

            try
            {
                // Directory é uma classe estatica que permite a manipulação dos diretorios
                // EnumerateDirectories que esta listando os diretorios/pastas
                // AllDirectories define a busca de todos os diretorios
                IEnumerable<string> pastas = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                System.Console.WriteLine("Pastas: ");
                foreach (string item in pastas)
                {
                    System.Console.WriteLine(item);
                }
                // Inumerar os arquivos
                IEnumerable<string> arquivos = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                // EnumerateFileSystemEntries para exibir tudo de uma vez
                foreach (string item in arquivos)
                {
                    System.Console.WriteLine(item);
                }

                // // Criar um Pasta
                // Directory.CreateDirectory(path + @"\Teste2");

                // // Deletar uma pasta
                // Directory.Delete(path + @"\Teste2");

                // Verificar se uma pasta existe
                bool pastaExiste = Directory.Exists(path + @"\Nova");
                System.Console.WriteLine(pastaExiste);
                System.Console.WriteLine($"A pasta existe: {pastaExiste}");
            }
            catch (Exception e)
            {
                System.Console.WriteLine("ocorreu erro");
                System.Console.WriteLine("e.Message");

            }
        }
    }
}