using ManageFunds.Core.Interfaces;
using System.Collections.Generic;

namespace ManageFunds.Core.Models
{
    public interface ICategoriesRepository : IRepository<Expenses>
    {
        //GetByIsbn
        Expenses GetById(string ExpensesId);

        List<Expenses> FetchByCode(string code);
    }
}