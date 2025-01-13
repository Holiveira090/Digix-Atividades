using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_26_ManipulacaoArquivos
{
    public class Exemplo2
    {
        static void Exe2()
        {
            string inicioParh = @"C:\Users\henriqueoliveira\Desktop\Teste1.txt";

            // Isso é uma conversa com o sistema operacional
            // Não é gerenciado pelo clr

            FileStream fs = null; // Essa é uma classe que permite leitura e escrita de arquivos, e é uma classe de baixo de baixo nivel

            StreamReader sr = null; // També classe de manipulação de arquivo como a Filestream, mas é de alto nivel

            try
            {
                fs = new FileStream(inicioParh, FileMode.Open);// Abre o arquivo

                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                System.Console.WriteLine(line);

                while (line != null)
                {
                    line = sr.ReadLine();
                    System.Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                // Eu preciso fechar o arquivo, pois o sistema operacional não faz isso automaticamente
                if (sr != null) sr.Close();
                if (fs != null) sr.Close();
            }
        }
    }
}