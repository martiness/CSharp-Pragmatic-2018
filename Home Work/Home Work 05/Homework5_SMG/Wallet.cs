using System;
using System.Collections.Generic;

namespace Homework5
{
    public class Wallet : IPersistable
    {
        // hint: I will explain generics next Monday
        private readonly List<Expences> _expenses = new List<Expences>();
        private readonly List<Income> _incomes = new List<Income>();

        public List<Expences> Expences
        {
            get { return _expenses; }
        }

        public List<Income> Incomes
        {
            get { return _incomes; }
        }

        public void AddExpense(Expences expense)
        {
            _expenses.Add(expense);
        }

        public void AddIncome(Income income)
        {
            _incomes.Add(income);
        }

        // ... more methods to work with the encapsulated fields 
        //     (e.g. _incomes and _expenses)
        public void Load(string fileName)
        {
            // will deserialize from file
            // hint: I will explain it next Wednesday
            throw new NotImplementedException();
        }

        public void Save(string fileName)
        {
            // will serialize to file 
            // hint: I will explain it next Wednesday
            throw new NotImplementedException();
        }
    }
}