using ManageFunds.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFunds
{
    public class Expenses
    {
       public int ExpensesId { get; set; }
       public DateTime Date { get; set; }
       public string Description { get; set; }
       public string User { get; set; }
       public int Amount { get; set; }     
       public bool Approved { get; set; }
       public Categories Categories { get; set; }
       public int CategoriesId { get; set; }
    }
}
