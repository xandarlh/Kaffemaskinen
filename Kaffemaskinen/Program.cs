using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    class Program
    {
        static void Main(string[] args)
        {
            HotDrinkMachine genericCoffeeMachine = new GenericCoffeeMachine("MochaMaster");
            HotDrinkMachine teaMachine = new TeaMachine("THE tea machine");
            HotDrinkMachine esspressoMachine = new EsspressoMachine("Esspresso machine");
            

            Console.WriteLine(genericCoffeeMachine.BrewHotDrink(3));
            Console.WriteLine(teaMachine.BrewHotDrink(1));
            Console.WriteLine(esspressoMachine.BrewHotDrink(1));


            Console.ReadLine();
        }
    }
}
