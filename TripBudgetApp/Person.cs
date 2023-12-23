using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripBudgetApp
{
    //Person is class to contains to basic information for every person which have commited in trip
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set;}

        public Account Account { get; set; }
        
        private string _bankAccountNumber;

        public string BankAccountNumber
        {
            get { return _bankAccountNumber; }
            set 
            {
                if (value.Length == 26)
                    _bankAccountNumber = value;
                else _bankAccountNumber = "";
                    }
                
        }
        public override string ToString()
        {
            return $"Name:{Name} Bank account number:{_bankAccountNumber}";
        }

    }
}
