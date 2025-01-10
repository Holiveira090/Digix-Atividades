using System;

namespace Atividade_09_01
{
    public class CurrentAccount : Account
    {
        public double CurrentBalance { get; private set; }

        public CurrentAccount(int accountNumber, double balance, Customer customer) : base(accountNumber, balance, customer)
        {
        }

        public override void Deposit(double amount)
        {
            if (amount > 0)
            {
                CurrentBalance += amount;
                Balance += amount; 
                AddTransaction($"Depósito: {amount:C2} - Saldo Atual: {CurrentBalance:C2}");
                Console.WriteLine($"Depósito realizado com sucesso! Novo saldo: {CurrentBalance:C2}");
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser maior que zero.");
            }
        }

        public override void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                CurrentBalance -= amount;
                Balance -= amount; 
                AddTransaction($"Saque: {amount:C2} - Saldo Atual: {CurrentBalance:C2}");
                Console.WriteLine($"Saque realizado com sucesso! Novo saldo: {CurrentBalance:C2}");
            }
            else
            {
                Console.WriteLine("O valor do saque deve ser maior que zero e menor ou igual ao saldo.");
            }
        }
    }


}
