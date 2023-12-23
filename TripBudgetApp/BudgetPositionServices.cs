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
        public BudgetPosition addPosition(BudgetPosition position)
        {
            var id = GetID();
            position.Id = id + 1;
            _positionsList.Add(position);
            return position;
        }
    }
}
