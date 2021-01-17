using ExpenseManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesTracker.Models
{
    public class ExpensesDataAccess
    {
        ExpensesDataBaseContext db = new ExpensesDataBaseContext();
        public IEnumerable<ExpensesModel> GetAllExpenses()
        {
                return db.ExpensesModel.ToList();
        }
        public IEnumerable<ExpensesModel> GetSearchResult(string searchString)
        {
            List<ExpensesModel> exp = new List<ExpensesModel>();

            exp = GetAllExpenses().ToList();
            return exp.Where(x => x.ExpenseName.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) != -1);

        }
 
        public void AddExpense(ExpensesModel expense)
        {
            db.ExpensesModel.Add(expense);
            db.SaveChanges();
        }

        public ExpensesModel GetExpenseData(int id)
        {
                ExpensesModel expense = db.ExpensesModel.Find(id);
                return expense;

        } 
        public void DeleteExpense(int id)
        {
                ExpensesModel expense = db.ExpensesModel.Find(id);
                db.ExpensesModel.Remove(expense);
                db.SaveChanges();
        }
    }
}
