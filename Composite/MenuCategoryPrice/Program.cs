namespace MenuCategoryPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cola = new MenuItem("Кока Кола", 2.50);
            var beer = new MenuItem("Бира", 3.80);
            var burger = new MenuItem("Телешки Бургер", 12.90);

            var drinkMenu = new MenuCategory("Напитки");
            var foodMenu = new MenuCategory("Храна");
            var mainMenu = new MenuCategory("Дневно Меню");

            drinkMenu.Add(cola);
            drinkMenu.Add(beer);

            foodMenu.Add(burger);

            mainMenu.Add(drinkMenu);
            mainMenu.Add(foodMenu);

            mainMenu.Display(1);

            Console.WriteLine($"\nОбща стойност на всички продукти в менюто: {mainMenu.GetPrice()} лв.");
        }
    }
}
