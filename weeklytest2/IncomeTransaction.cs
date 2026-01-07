using System;

namespace PettyCashLedger
{
    // Represents an income transaction
    class IncomeTransaction : Transaction, IReportable
    {
        public string Source { get; set; }

        public IncomeTransaction(int id, DateTime date, decimal amount, string description, string source)
            : base(id, date, amount, description)
        {
            Source = source;
        }

        public string GetSummary()
        {
            return $"[INCOME] {Date.ToShortDateString()} | {Source} | +${Amount} | {Description}";
        }
    }
}
