namespace Coffee_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FacadeCoffee facadeCoffee = new FacadeCoffee();

            facadeCoffee.StartCoffeeMachine();
            facadeCoffee.MakeCoffee();
            facadeCoffee.StopCoffeeMachine();
        }
    }
}
