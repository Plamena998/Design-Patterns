using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine
{
    public class Serving
    {
        public void AddSugar()
        {
            Console.WriteLine("Adding suggar...");
        }
        public void AddCream()
        {
            Console.WriteLine("Adding cream...");
        }
        public void Serve() 
        { 
            Console.WriteLine("Your coffee is ready!");
        }
    }
}
