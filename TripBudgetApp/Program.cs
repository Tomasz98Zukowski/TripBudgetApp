namespace TripBudgetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var menuService = new MenuServices(MainMenu());
            var budgetPositionService = new BudgetPositionServices();
            var position = budgetPositionService.AddPosition();
            

            static List<Menu> MainMenu()
            {
                return new List<Menu>()
                {
                    new Menu { Id = 1, Name = "Add budget position"},
                    new Menu { Id = 2, Name = "Add person"},
                    new Menu { Id = 3, Name = "Update position"},
                    new Menu { Id = 4, Name = "Show all positions"},
                    new Menu { Id = 5, Name = "Delete position"},
                    new Menu { Id = 6, Name  = "Show details"},
                    new Menu { Id = 7, Name = "Quit program"},
                };
                
            }
        }
    }
}
