using ManageFunds.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFunds.Core.Models
{
    public class MainBL
    {
         private IExpensesRepository _expensesRepository;
        private ICategoriesRepository _categoriesRepository;

        public MainBL(IExpensesRepository expensesRepository, ICategoriesRepository categoriesRepository)
        {
            _expensesRepository = expensesRepository;
            _categoriesRepository = categoriesRepository;
        }
        internal void  AddExpenses(Expenses newExpenses)
        {
            if (newExpenses == null) throw new ArgumentNullException();
            _expensesRepository.Add(newExpenses);
        }

         internal List<Expenses> FetchExpensesByApproved(Categories chosenApproved)
        {
            if (chosenApproved = false) throw new ArgumentNullException();
            return _expensesRepository.FetchByCategoriesCode(chosenCategories.Code);
        }

        internal List<Expenses> FetchExpenses()
        {
            var expenses = _expensesRepository.Fetch();
            return (List<Expenses>)expenses;
        }

        internal void DeleteExpenses(Expenses expensesToDelete)
        {
            if (expensesToDelete  == null) throw new ArgumentNullException();

            _expensesRepository.Delete(expensesToDelete);
        }

        internal void UpdateExpenses(Expenses expensesToUpdate)
        {
            if (expensesToUpdate == null) throw new ArgumentNullException();

            _expensesRepository.Update(expensesToUpdate);
        }

        internal Expenses GetByCode(string code)
        {
            throw new NotImplementedException();
        }
    }
}


