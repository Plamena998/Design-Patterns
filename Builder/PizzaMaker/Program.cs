namespace PizzaMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var builder = new PizzaBuilder();
            var director = new PizzaDirector();

            director.MakeMargarita(builder);
            Pizza Margarita = builder.Build();

            Margarita.Show();

            Pizza customPizza = new PizzaBuilder()
            .SetDough("thin")
            .setSauce("BBQ")
            .AddChees()
            .AddPepperoni()
            .AddOlives()
            .Build();

            customPizza.Show();
        }
    }
}
