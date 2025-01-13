using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_26_ManipulacaoArquivos
{
    public class Exemplo6
    {
        static void Main(string[] args)
        {
            string inicioParh = @"C:\Users\henriqueoliveira\Desktop\Teste1.txt";
            System.Console.WriteLine($"Directory Separator Char {Path.DirectorySeparatorChar}");
            System.Console.WriteLine($"Separador de caminho: {Path.PathSeparator}");
            System.Console.WriteLine($"Retorna o diretorio do arquivo {Path.GetDirectoryName(inicioParh)}");
            System.Console.WriteLine($"Retorna o nome do arquivo {Path.GetFileName(inicioParh)}");
            System.Console.WriteLine($"Retorna o nome do arquivo sem a extensao {Path.GetFileNameWithoutExtension(inicioParh)}");
            System.Console.WriteLine($"Retorna somente a extenso do arquivo {Path.GetExtension(inicioParh)}");
            
        }
    }
}