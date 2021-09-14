
using ManageFunds.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFunds.EF.Configurations
{
    public class ExpensesContext : DbContext
    {
        public DbSet<Expenses> Expenses { get; set; }

        public DbSet<Categories> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
		Database=ExpensesDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Expenses>(new ExpensesConfiguration());
        }
    }
}
