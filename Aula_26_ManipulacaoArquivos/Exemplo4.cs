using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_26_ManipulacaoArquivos
{
    public class Exemplo4
    {
        static void Exe4()
        {
            string inicioParh = @"C:\Users\henriqueoliveira\Desktop\Teste1.txt";
            string FinalParh = @"C:\Users\henriqueoliveira\Desktop\Teste2.txt";
            try
            {
                string[] lines = File.ReadAllLines(inicioParh);

                using (StreamWriter sw = File.AppendText(FinalParh))
                {
                    foreach (string item in lines)
                    {
                        sw.WriteLine(item.ToUpper()); // Escreve a linha em maiusculo
                        //para deixar todos minusculos sw.WriteLine(item.ToLower());
                        // Para inverter a ordem sw.WriteLine(item.Reverse()).ToArray());
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