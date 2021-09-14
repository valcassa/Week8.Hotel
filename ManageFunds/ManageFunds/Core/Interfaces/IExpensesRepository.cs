using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFunds.Core.Interfaces
{
    public interface IExpensesRepository : IRepository<Expenses>
    {
        List<Expenses> FetchByUser(string user);
        List<Expenses> FetchExpensesbyUser(object code);
        void Add(object newExpenses);

        List<Expenses> FetchByCategoriesCode(string code);
        bool Delete(Expenses expensesToDelete);
        List<Expenses> Fetch();
        List<Expenses> FetchByCategoriesCode(object code);
    }
}
