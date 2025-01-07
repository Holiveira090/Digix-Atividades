using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_07_01
{
    public class Empregados
    {
        private int NumeroMaximo = 50;
        public Empregado[] empregados { get; set; }
        public int NumeroEmpregados { get; set; }

        public Empregados()
        {
            empregados = new Empregado[NumeroMaximo]; 
            NumeroEmpregados = 0;
        }

        public void Insere(Empregado empregado)
        {
            if (NumeroEmpregados < NumeroMaximo)
            {
                empregados[NumeroEmpregados] = empregado;
                NumeroEmpregados++;
            }
            else
            {
                Console.WriteLine("Número máximo de empregados atingido.");
            }
        }

        public void Imprime()
        {
            for (int i = 0; i < NumeroEmpregados; i++)
            {
                Console.WriteLine($"Empregado {i + 1}: {empregados[i].getNome()}, Salário: {empregados[i].GetSalario()}");
            }
        }
        
        public void Write(string write)
        {
            for (int i = 0; i < NumeroEmpregados; i++)
            {
                if (empregados[i].getNome() == write)
                {
                    Console.WriteLine($"Empregado: {empregados[i].getNome()}, Salário: {empregados[i].GetSalario()}");
                }
            }
        }

        public void Read(string read)
        {
            Console.WriteLine($"Leitura: {read}");
        }
        public double FolhaPagamento()
        {
            double total = 0;
            for (int i = 0; i < NumeroEmpregados; i++)
            {
                total += empregados[i].GetSalario();  
            }
            return total;
        }
    }
}