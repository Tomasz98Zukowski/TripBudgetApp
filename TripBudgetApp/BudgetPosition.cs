using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripBudgetApp
{
    public class BudgetPosition
    {
        //Create main class to contains all atributes of Budget Positions
        public int Id { get; set; }
        public string Title { get; set; }
        public Category ExpenseCategory { get; set; }
        public decimal ExpenseAmount { get; set; }
        public Account SourceForExpense { get; set; }
        public Person ExpenseCoomates {  get; set; }
        public DateOnly Date {  get; set; }
        public string Description { get; set; }




    }
}
