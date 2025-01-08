using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_24_OO_excecao
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit = 5000;
        public Account(int number, string holder)
        {
            Number = number;
            Holder = holder;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
            System.Console.WriteLine($"Deposito realizado com sucesso!\nNovo saldo: {Balance:C2}");
        }
        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainException("Você não pode sacar um valor maior que o saldo!");
            }
            else if (amount > WithdrawLimit)
            {
                throw new DomainException($"Limite de saque excedido! (Maximo permitido: {WithdrawLimit:C2})");
            }
            else
            {
                Balance -= amount;
                System.Console.WriteLine($"Saque realizado com sucesso!\nNovo saldo: {Balance:C2}");
            }
        }
        public void ExibirInformacoes()
        {
            System.Console.WriteLine($"Conta: {Number}\nTitular: {Holder}\nSaldo: {Balance:C2}\nLimite de saque: {WithdrawLimit:C2}");
        }
    }
}