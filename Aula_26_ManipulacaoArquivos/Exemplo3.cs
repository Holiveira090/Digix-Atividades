using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_26_ManipulacaoArquivos
{
    public class Exemplo3
    {
        static void Exe3()
        {
            string inicioParh = @"C:\Users\henriqueoliveira\Desktop\Teste1.txt";

            try
            {
                using (FileStream fs = new FileStream(inicioParh, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();
                        System.Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {

                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}