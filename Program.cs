using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp___cSharp_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCarsInCart = 0;

            Car c = new Car("Chev","Blazer",22345.67m);
            Car d = new Car("Ford", "Mustange", 33456.78m);
            Car e = new Car("Honda", "Civic", 19345.89m);

            Console.WriteLine($"Car: {c.Make} - {c.Model} - {c.Price.ToString("C")}");
            Console.WriteLine($"Car: {d.Make} - {d.Model} - {d.Price.ToString("C")}");
            Console.WriteLine($"Car: {e.Make} - {e.Model} - {e.Price.ToString("C")}");
            Console.WriteLine($"There are {Car.numOfCars} cars in the CLASS");

            Store s = new Store();
            s.ShoppingList.Add(c);
            s.ShoppingList.Add(d);

            numOfCarsInCart = s.ShoppingList.Count;
            decimal total = s.CheckOut();

            Console.WriteLine($"Total Cost for {numOfCarsInCart} cars is {total.ToString("C")}");

        }
    }
}
