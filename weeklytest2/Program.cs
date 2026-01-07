using System;
using System.Collections.Generic;

namespace PettyCashLedger
{
    class Program
    {
        static void Main()
        {
            //Create Income Ledger
            Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();

            //Record income
            incomeLedger.AddEntry(
                new IncomeTransaction(1, DateTime.Now, 500, "Initial Replenishment", "Main Cash")
            );

            //Create Expense Ledger
            Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();

            //Record expenses
            expenseLedger.AddEntry(
                new ExpenseTransaction(1, DateTime.Now, 20, "Bought pens and paper", "Stationery")
            );

            expenseLedger.AddEntry(
                new ExpenseTransaction(2, DateTime.Now, 15, "Snacks for team", "Food")
            );

            //Calculating totals
            decimal totalIncome = incomeLedger.CalculateTotal();
            decimal totalExpense = expenseLedger.CalculateTotal();
            decimal balance = totalIncome - totalExpense;

            Console.WriteLine("--- PETTY CASH SUMMARY ---");
            Console.WriteLine($"Total Income: ${totalIncome}");
            Console.WriteLine($"Total Expense: ${totalExpense}");
            Console.WriteLine($"Net Balance: ${balance}");

            //Polymorphic output
            Console.WriteLine("\n --- TRANSACTION DETAILS --- ");
            List<IReportable> reports = new List<IReportable>();
            reports.AddRange(incomeLedger.GetAll());
            reports.AddRange(expenseLedger.GetAll());

            foreach (var r in reports)
            {
                Console.WriteLine(r.GetSummary());
            }
        }
    }
}


