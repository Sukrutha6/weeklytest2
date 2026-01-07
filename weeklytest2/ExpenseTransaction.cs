using System;

namespace PettyCashLedger
{
    // Represents an expense transaction
    class ExpenseTransaction : Transaction, IReportable
    {
        public string Category { get; set; }

        public ExpenseTransaction(int id, DateTime date, decimal amount, string description, string category)
            : base(id, date, amount, description)
        {
            Category = category;
        }

        public string GetSummary()
        {
            return $"[EXPENSE] {Date.ToShortDateString()} | {Category} | -${Amount} | {Description}";
        }
    }
}
