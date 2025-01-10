using System;
using System.Collections.Generic;

namespace Atividade_09_01
{
    public abstract class Account
    {
        public int AccountNumber { get; private set; }
        public double Balance { get;  set; }
        public Customer Customer { get; private set; }

        
        public List<string> TransactionHistory { get; private set; }

        public Account(int accountNumber, double balance, Customer customer)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Customer = customer;
            TransactionHistory = new List<string>();  
        }

        public void AddTransaction(string transaction)
        {
            TransactionHistory.Add(transaction);
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);

        public void ShowTransactionHistory()
        {
            if (TransactionHistory.Count == 0)
            {
                Console.WriteLine("Nenhuma transação realizada.");
            }
            else
            {
                foreach (var transaction in TransactionHistory)
                {
                    Console.WriteLine(transaction);
                }
            }
        }
    }

}
