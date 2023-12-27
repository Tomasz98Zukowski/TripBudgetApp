using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripBudgetApp
{
    public class PersonServices
    {
        public readonly List<Person> _persons = new List<Person>
        {
            new Person { Id = 1,Name="ADMIN",BankAccountNumber=""}
        };

        private int GetID()
        {
            if (_persons.Count == 0) return 0;
            return _persons[_persons.Count - 1].Id;
        }
        //add person to list of persons
        public void AddPerson(Person person)
        {            
            _persons.Add(person);
        }
       
        public Person UpdatePosition(Person person)
        {
            return person;
        }

        //delete person from the list of persons

        public bool DeletePerson(int id)
        {
            var person = GetPersonById(id);
            if (person == null)
            {
                return false;
            }
            _persons.Remove(person);
            return true;
        }

        // This method return Budget position by ID

        public Person? GetPersonById(int id)
        {
            foreach (var person in _persons)
            {
                if (person.Id == id)
                {
                    return person;
                }
            }
            return null;
        }

        //Method to create new person

        public Person NewPerson()
        {
            var person = new Person()
            {
                Id = GetID() + 1,
            };
            SetName(person);
            SetNumber(person);
            return person;
        }

        public List<Person> ShowAllPersons()
        {
            return _persons;
        }

        private void SetName(Person person)
        {
            
            bool isGood = false;
            string name ="";
            while(!isGood)
            {
                Console.WriteLine("Enter person name:");
                name = Console.ReadLine();
                isGood = !string.IsNullOrWhiteSpace(name);
            }
            person.Name = name;
        }
        private void SetNumber(Person person)
        {
            bool isGood = false;
            string accountNumber = "";
            while (!isGood)
            {
                Console.WriteLine("Enter account number");
                accountNumber = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(accountNumber) || accountNumber.Length == 26)
                    isGood = true;
                else isGood = false;
            }
            person.BankAccountNumber = accountNumber;

        }


    }
}
