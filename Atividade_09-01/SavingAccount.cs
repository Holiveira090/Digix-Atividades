using System;

namespace Atividade_09_01
{
    public class SavingAccount : Account
    {
        public double SavingBalance { get; private set; }

        public SavingAccount(int accountNumber, double balance, Customer customer) : base(accountNumber, balance, customer)
        {
        }

        public override void Deposit(double amount)
        {
            if (amount > 0)
            {
                SavingBalance += amount;
                Balance += amount; 
                AddTransaction($"Depósito: {amount:C2} - Saldo Atual: {SavingBalance:C2}");
                Console.WriteLine($"Depósito realizado com sucesso! Novo saldo: {SavingBalance:C2}");
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
                SavingBalance -= amount;
                Balance -= amount;
                AddTransaction($"Saque: {amount:C2} - Saldo Atual: {SavingBalance:C2}");
                Console.WriteLine($"Saque realizado com sucesso! Novo saldo: {SavingBalance:C2}");
            }
            else
            {
                Console.WriteLine("O valor do saque deve ser maior que zero e menor ou igual ao saldo.");
            }
        }
    }

}
