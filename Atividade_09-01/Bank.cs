using System;
using System.Collections.Generic;

namespace Atividade_09_01
{
    public class Bank
    {
        public int Code { get; set; }
        public string Address { get; set; }
        public List<Account> Accounts { get; set; }

        public Bank(int code, string address)
        {
            Code = code;
            Address = address;
            Accounts = new List<Account>(); 
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
            Console.WriteLine("Conta adicionada com sucesso.");
        }

        public void ListAllAccounts()
        {
            Console.WriteLine("\nLista de Contas no Banco:");
            foreach (var account in Accounts)
            {
                Console.WriteLine($"Número da Conta: {account.AccountNumber}, Titular: {account.Customer.Name}, Saldo: {account.Balance:C2}");
            }
        }

        public Account FindAccount(int number)
        {
            var account = Accounts.Find(acc => acc.AccountNumber == number);
            if (account == null)
            {
                throw new AccountNotFoundException("Conta não encontrada.");
            }
            return account;
        }
    }
}
