using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_OO_Exercicio
{
    public class Banco
    {
        public string Titular { get; set; }
        public int NumConta { get; private set;}
        public double Saldo { get; private set; }

        public Banco(string titular, int numconta)
        {
            Titular = titular;
            NumConta = numconta;
        }
        public Banco(string titular, int numconta, double saldo) : this(titular, numconta)
        {
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            System.Console.WriteLine($"Voce Depositou {valor:C2}, seu saldo atual é de {Saldo:C2}");
        }
        public void Sacar(double valor)
        {
            if (valor < Saldo)
            {
                Saldo -= valor + 5;
                System.Console.WriteLine($"Voce sacou {valor:C2} (Taxa: R$5,00), seu saldo restante é de {Saldo:C2}");
            }
            else
            {
                System.Console.WriteLine("Impossivel fazer esse saque");
            }
        }
        public override string ToString()
        {
            return $"Olá {Titular}\nNúmero da conta: {NumConta}\nSaldo atual: {Saldo.ToString("C2")}";
        }

    }
}