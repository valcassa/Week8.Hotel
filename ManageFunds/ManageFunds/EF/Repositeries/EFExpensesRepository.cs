using ManageFunds.Core.Interfaces;
using ManageFunds.EF.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFunds.EF.Repositeries
{
    class EFExpensesRepository :IExpensesRepository
    {
        private readonly ExpensesContext ctx;

        public EFBookRepository()
        {
            ctx = new ExpensesContext();
        }

        public bool AddExpenses(Expenses newExpenses)
        {
            if (newExpenses == null) return false;
            try { var categories = ctx.Expenses
                        .FirstOrDefault(e => e.CategoriesId == newExpenses.Categories.ExpensesId);
                categories.Expenses.Add(newExpenses);
                ctx.SaveChanges();
                return true;
            }
            catch(Exception ex) { return false; }
            }


        

        public bool Delete(Expenses expensesToDelete)
        {
        if (expensesToDelete == null) return false;       }

        public List<Expenses> Fetch()
            {
        try
        {
            var books = ctx.Expenses.Include(e => e.Categories)
                .ToList();
            return expenses;
        }
        catch (Exception)
        {
            return new List<Expenses>();
        }
    }
    public List<Expenses> FetchByCategoriesCode(string code)
        {
        if (string.IsNullOrEmpty(code))
            return null;
    }
    
        public Expenses GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Expenses item)
        {
            throw new NotImplementedException();
        }
     
    public List<Expenses> Fetch()
    {
        try
        {
            var expenses = ctx.Expenses.Include(e => e.Categories)
                .ToList();
            return expenses;
        }
        catch (Exception)
        {
            return new List<Expenses>();
        }
    }
}    

