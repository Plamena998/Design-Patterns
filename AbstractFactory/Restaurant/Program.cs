using Restaurant.Abstraction;
using Restaurant.ConcreteFactories;
using Restaurant.Products;

Console.WriteLine("Please select your restaurant:");
Console.WriteLine("[1] Bulgarian, [2] French, [3] Italian");

if(int.TryParse(Console.ReadLine(), out int restaurantstyle)){

    RestaurantFactory restaurantFactory = null;

    switch (restaurantstyle)
    {
        case 1:
            restaurantFactory = new BulgarianFactory();
            break;
        case 2:
            restaurantFactory = new FrechFactory();
            break;
        case 3:
            restaurantFactory = new ItalianFactory();
            break;
        default:
            Console.WriteLine("Invalid item.");
            break;
    }

    restaurantFactory.CreateChef().Cook();

    Console.WriteLine("Please select what to order:");
    Console.WriteLine("[1] dish, [2] drink");

    if(int.TryParse(Console.ReadLine(), out int orderItem))
    {
        switch (orderItem)
        {
            case 1:
                 restaurantFactory.CreateDish().Serve();
                break;
            case 2:
                restaurantFactory.CreateDrink().Pour();
                break;
             default:
                Console.WriteLine("Invalid item.");
                break;
        }
    }

}