using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripBudgetApp
{
    //This class contains Id and Tile of positions of application menu
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        { return $"{Name}"; }
    }

    
}
