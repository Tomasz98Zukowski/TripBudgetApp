using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripBudgetApp
{
    public class AccountServices
    {
        public readonly List<Account> _accountsList = new List<Account>();

        //Metod give for us last item id's on list 
        private int GetID()
        {
            if (_accountsList.Count == 0) return 0;
            return _accountsList[_accountsList.Count - 1].Id;
        }

        //Metod add account to list of accounts 
        public Account AddPositionList(Account account)
        {
            _accountsList.Add(account);
            return account;
        }

        public Account UpdatePosition(Account account)
        {
            return account;
        }

        //delete position from the list of accounts

        public bool DeletePosition(int id)
        {
            var account = GetPositionById(id);
            if (account == null)
            {
                return false;
            }
            _accountsList.Remove(account);
            return true;
        }

        // This method return Account position by ID

        public Account? GetPositionById(int id)
        {
            foreach (var account in _accountsList)
            {
                if (account.Id == id)
                {
                    return account;
                }
            }
            return null;
        }

        //method to create new account 

        public Account? AddAccount()
        {
            var account = new Account()
            {
                Id = GetID() + 1,
                Balance = 0,
            };           
            SetLimit(account);
            SetOwner(account);
            return account;
        }
        private void SetLimit (Account account)
        {
            decimal limit=0;
            bool isDecimal = false;
            Console.WriteLine("Set your limit to this trip");
            while (!isDecimal)
            {
                isDecimal = decimal.TryParse(Console.ReadLine(), out limit);
            }
            account.Limit = limit;
            Console.WriteLine($"Your limit is {limit}");
        }

        private void SetOwner(Account account)
        {
            Console.WriteLine("Select owner");
            PersonServices personServices = new PersonServices();
            List<Person> persons = personServices.ShowAllPersons();
            bool isGood = false;
            


            while (!isGood)
            {
                
 
                int i = 0;
                foreach (Person person in persons)
                {
                    Console.WriteLine("Select account owner");
                    Console.WriteLine($"{++i} :{person}");
                    Console.WriteLine("If you want create new owner insert 99");
                }
                var key = Console.ReadLine();
                if (int.TryParse(key, out int x) && (x == persons.LongCount()))
                {
                    isGood = true;
                    account.Owner = persons[x-1];
                    Console.WriteLine($"Accound ID: #{account.Id} have owner:{account.Owner}");
                }
                if (int.TryParse(key, out x) && (x == 99))
                {
                    Person person = personServices.NewPerson();
                    personServices.AddPerson(person);
                }

            }
            
        }

    }
}
   