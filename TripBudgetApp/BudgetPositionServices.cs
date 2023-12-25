using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripBudgetApp
{
    public class BudgetPositionServices
    {
        public readonly List<BudgetPosition> _positionsList = new List<BudgetPosition>();

        //Metod give for us last item id's on list 
        private int GetID()
        {
            if (_positionsList.Count == 0)   return 0;
            return _positionsList[_positionsList.Count - 1].Id;
        }

        //Metod add position to list of positions 
        public BudgetPosition AddPositionList(BudgetPosition position)
        {
            
            _positionsList.Add(position);
            return position;
        }

        public BudgetPosition UpdatePosition(BudgetPosition position)
        {
            return position;
        }

        //delete position from the list of positions

        public bool DeletePosition (int id)
        {
            var position = GetPositionById(id);
            if (position == null)
            {
                return false;
            }
            _positionsList.Remove(position);
            return true;
        }

        // This method return Budget position by ID

        public BudgetPosition? GetPositionById(int id)
        {
            foreach (var position in _positionsList)
            {
                if (position.Id == id)
                {
                    return position;
                }
            }
            return null;
        }

        //method to create new position 

        public BudgetPosition? AddPosition()
        {
            var position = new BudgetPosition()
            {
                Id = GetID() + 1,
                Date = DateTime.Today,
            };

            if (!SetTitle(position))
            {
                return null;
            }
            Console.WriteLine();
            if (!SetCategory(position))
            {
                return null;
            }
            Console.WriteLine();
            if (!SetValue(position))
            {
                return null;
            }
            Console.WriteLine();
            SetDescription(position);
            Console.WriteLine();
            Console.WriteLine(position);
            return position;
        }

        //method to modify new position

        public BudgetPosition? ModifyPosition(BudgetPosition position)
        {
            if (!SetTitle(position))
            {
                return null;
            }
            
            if (!SetCategory(position))
            {
                return null;
            }
            Console.WriteLine();
            if (!SetValue(position))
            {
                return null;
            }
            SetDescription(position);
            
            Console.WriteLine(position);
            return position;
        }


        //set title of position

        private bool SetTitle (BudgetPosition position)
        {
            Console.WriteLine("Enter estimate title:");
            var title = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Title can not be empty");
                return false;
            }
            position.Title = title;
            return true;
        }

        //set category of expense

        private bool SetCategory(BudgetPosition position)
        {
            Console.WriteLine("Select expense category: (1-Nocleg, 2-Transport, 3-Jedzenie, 4-Atrakcje)");
            var key = Console.ReadKey();
            switch (key.Key) 
            {
                case ConsoleKey.D1 :

                    position.ExpenseCategory = Category.Nocleg;
                    return true;
                    break;
                case ConsoleKey.D2:

                    position.ExpenseCategory = Category.Transport;
                    return true;
                    break;
                case ConsoleKey.D3:

                    position.ExpenseCategory = Category.Jedzenie;
                    return true;
                    break;
                case ConsoleKey.D4:

                    position.ExpenseCategory = Category.Atrakcje;
                    return true;
                    break;

                default:
                    return false;
            }
        }
        //set amount of expense
        private bool SetValue (BudgetPosition position)
        {
            Console.WriteLine("Insert amount(PLN)");
            decimal value;
            var isValue = decimal.TryParse(Console.ReadLine(),out value);
            if(isValue)
            {
                position.ExpenseAmount = value;
                return true;
            }
            return false;

        }

        //set description of expense

        private void SetDescription(BudgetPosition position)
        {
            Console.WriteLine("Insert expense description:");
            position.Description = Console.ReadLine();
        }


        //return list of positions

        public IReadOnlyList<BudgetPosition> GetAllPositions()
        {
            return _positionsList;
        }
    }
}
