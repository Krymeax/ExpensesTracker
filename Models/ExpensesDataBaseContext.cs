using ExpensesTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ExpenseManager.Models
{
    public class ExpensesDataBaseContext : DbContext
    {
        public virtual DbSet<ExpensesModel> ExpensesModel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ExpensesDataBase;Integrated Security=True;");
            }
        }
    }
}