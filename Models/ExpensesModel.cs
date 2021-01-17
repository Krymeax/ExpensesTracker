using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesTracker.Models
{
    public class ExpensesModel
    {
        [Key]
        public int ExpenseId { get; set; }
        [Required]
        public string ExpenseName { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ExpenseDate { get; set; } = DateTime.Now; // change to choose time/date
        public Boolean Expired { get; }
        public DateTime DueDate { get; set; }
        // public Boolean RecursiveTransaction {get;set;}
    }
}
