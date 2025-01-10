using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_09_01
{
    public class ATMTransactions
    {
        public int TransactionID { get; private set; }
        public DateTime Date { get; private set; }
        public double Amount { get; private set; }

        public ATMTransactions(int transactionID, DateTime date, double amount)
        {
            TransactionID = transactionID;
            Date = date;
            Amount = amount;
        }

        public void Modifies()
        {
            Console.WriteLine($"ID da Transação: {TransactionID} \nData: {Date} \nValor: {Amount}");
        }
    }

}