using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyWalletProject02
{
    public class Wallet
    {
        private List<EntityBase> _entities = new List<EntityBase>();

        //private readonly List<Expense> _expenses = new List<Expense>();
        //private readonly List<Income> _incomes = new List<Income>();

        public List<Expense> Expences
        {
            get { return _entities.OfType<Expense>().ToList(); }
        }

        public List<Income> Incomes
        {
            get { return _entities.OfType<Income>().ToList(); }
        }

        public void AddExpense(Expense expense)
        {
            _entities.Add(expense);

            var largeItem = _entities.Where(e => e.Amount > 1000);

            var largeItemWithLINQ = from e in _entities
                                    where e.Amount > 1000
                                    select e;


        }

        public void Add<T>(T entity) where T : EntityBase
        {
            _entities.Add(entity);
        }

        public void LastMonthExpense()
        {
            _entities.OfType<Expense>().Sum(e => e.Amount);
            //.Sum(e => e.Amount && e.Timestamp > DateTime.Now.AddDays(-30));
        }
    }
}
