using ExpenseManager.Models;
using ExpensesTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesTracker.Controllers
{
    public class ExpensesController : Controller
    {

        ExpensesDataAccess expensesObject = new ExpensesDataAccess();
        public IActionResult Index(string searchString)
        {
            List<ExpensesModel> expensesList = new List<ExpensesModel>();
            expensesList = expensesObject.GetAllExpenses().ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                expensesList = expensesObject.GetSearchResult(searchString).ToList();
            }
            return View(expensesList);
        }

        public ActionResult AddEditExpenses(int itemId)
        {
            ExpensesModel model = new ExpensesModel();
            if (itemId > 0)
            {
                model = expensesObject.GetExpenseData(itemId);
            }
            return PartialView("_addExpenseForm", model);
        }

        public ActionResult ExpensesForm()
        {
            return View();
        }
    }
}
