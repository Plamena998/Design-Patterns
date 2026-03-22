using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaker
{
    public class PizzaDirector
    {
        public void MakeMargarita(PizzaBuilder builder)
        {
            builder.SetDough("thin")
                    .setSauce("tomatto sauce")
                    .AddChees();
        }
        public void MakePepperoni(PizzaBuilder builder)
        {
            builder.SetDough("thin")
                    .setSauce("hot pepper sauce")
                    .AddPepperoni()
                    .AddOlives()
                    .AddChees();
        }
    }
}
