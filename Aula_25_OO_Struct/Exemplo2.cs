using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25_OO_Struct
{

    public struct ContaBancariaStruct
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public ContaBancariaStruct(int numero, string titular, decimal saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Deposito(decimal valor)
        {
            Saldo += valor;
        }
        public void Saque(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
        }
        public void AlterarSaldo(decimal valor)
        {
            this = new ContaBancariaStruct(this.Numero, this.Titular, valor + Saldo);
        }

        public override string ToString()
        {
            return $"Numero: {Numero}, Titular: {Titular}, Saldo: {Saldo}";
        }
    }

    public class ContaBancariaClasse
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public ContaBancariaClasse(int numero, string titular, decimal saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Deposito(decimal valor)
        {
            Saldo += valor;
        }
        public void Saque(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
        }
        public void AlterarSaldo(decimal valor)
        {
            Saldo += valor;
            System.Console.WriteLine($"Voce alterou seu saldo para {Saldo:C2}");
        }

        public override string ToString()
        {
            return $"Numero: {Numero}, Titular: {Titular}, Saldo: {Saldo}";
        }
    }
    class Exe
    {
        static void Main(string[] args)
        {
            ContaBancariaStruct conta1 = new ContaBancariaStruct(1, "Maria", 1000);
            conta1.AlterarSaldo(500);
            System.Console.WriteLine(conta1);

            ContaBancariaClasse conta2 = new ContaBancariaClasse(2, "João", 1000);
            conta1.AlterarSaldo(500);
            System.Console.WriteLine(conta2);

        }
    }
}
