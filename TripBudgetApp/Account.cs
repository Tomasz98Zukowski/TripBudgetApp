using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripBudgetApp
{
    //Every person will have account so it's class which contains basic information about all accounts
    public class Account
    {
        public int Id { get; set; }
        public Person Owner { get; set; }
        public decimal Balance { get; set; }
        public decimal Limit { get; set; }
        public override string ToString()
        {
            return $"Id:{Id} Owner:{Owner.Name} Balance:{Balance} Limit{Limit}";
        }

    }
}
