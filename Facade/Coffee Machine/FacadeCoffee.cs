using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine
{
    public class FacadeCoffee
    {
        Power power;
        HeatingUp heatingUp;
        CoffeeChoice coffeeChoice;
        Serving serving;

        public FacadeCoffee()
        {
            this.power = new Power();
            this.coffeeChoice = new CoffeeChoice();
            this.heatingUp = new HeatingUp();
            this.serving = new Serving();
        }

        public void StartCoffeeMachine()
        {
            Console.WriteLine("Start your coffee machine...");
            power.On();
            heatingUp.Heating();
        }

        public void MakeCoffee()
        {
            Console.WriteLine("Lets make coffee...");
            coffeeChoice.MakeEspresso();
            serving.AddSugar();
            serving.AddCream();
            serving.Serve();
        }
        public void StopCoffeeMachine() {
            Console.WriteLine("Turn off your coffee machine...");
            power.Off();
        }
    }
}
