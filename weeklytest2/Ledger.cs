using System;
using System.Collections.Generic;
using System.Linq;

namespace PettyCashLedger
{
    // Generic Ledger class with type safety
    class Ledger<T> where T : Transaction
    {
        private List<T> transactions = new List<T>();
        // Add a transaction
        public void AddEntry(T entry)
        {
            transactions.Add(entry);
        }
        // Filter transactions by date
        public List<T> GetTransactionsByDate(DateTime date)
        {
            return transactions
                .Where(t => t.Date.Date == date.Date)
                .ToList();
        }
        // Calculate total amount
        public decimal CalculateTotal()
        {
            return transactions.Sum(t => t.Amount);
        }
        // Return all transactions
        public List<T> GetAll()
        {
            return transactions;
        }
    }
}
