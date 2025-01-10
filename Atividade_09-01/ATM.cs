using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_09_01
{
    public class ATM
    {
        public Location Location { get; set; }
        public string ManagedBy { get; set; }
        public List<ATMTransactions> ATMTransactions { get; private set; }
        private int transactionCounter;

        public ATM(Location location, string managedBy)
        {
            Location = location;
            ManagedBy = managedBy;
            ATMTransactions = new List<ATMTransactions>();
            transactionCounter = 0;
        }

        public void RegisterTransaction(ATMTransactions transaction)
        {
            ATMTransactions.Add(transaction);
            Console.WriteLine($"Transação registrada com sucesso! ID da transação: {transaction.TransactionID}");
        }

        public int GetNextTransactionID()
        {
            transactionCounter++;
            return transactionCounter;
        }
    }



}