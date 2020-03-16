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
            string carMake = "";
            string carModel = "";
            decimal carPrice = 0.00m;
            Car newCar;
            Store cart = new Store();
            int action = -1;

            while (action != 0)
            {
                action = ChooseAction();
                switch (action)
                {
                    case 1:
                        Console.WriteLine("What is the car make? Chev, Ford, or Honda");
                        carMake = Console.ReadLine();
                        Console.WriteLine("What is the car model? Compact, Full, or SUV");
                        carModel = Console.ReadLine();
                        Console.WriteLine("What is the car price?");
                        carPrice = decimal.Parse(Console.ReadLine());

                        newCar = new Car(carMake, carModel, carPrice);
                        Console.WriteLine($"\nCar Added:");
                        Car.prePrint = "\t";
                        Console.WriteLine($"{newCar.ToString()}\n");

                        cart.CarList.Add(newCar);
                        Console.WriteLine($"\nCars in Cart:");
                        Store.prePrint = "\t";
                        Console.WriteLine($"{cart.ToString()}\n");

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            }
        }

        static public int ChooseAction()
        {
            int choice;
            Console.WriteLine($"Choose an action:\n" +
                $"    0 - quit\n" +
                $"    1 - add new car\n" +
                $"    2 - add car to cart\n" +
                $"    3 - checkout");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}




//int numOfCarsInCart = 0;

//Car c = new Car("Chev","Blazer",22345.67m);
//Car d = new Car("Ford", "Mustange", 33456.78m);
//Car e = new Car("Honda", "Civic", 19345.89m);

//Console.WriteLine($"Car: {c.Make} - {c.Model} - {c.Price.ToString("C")}");
//Console.WriteLine($"Car: {d.Make} - {d.Model} - {d.Price.ToString("C")}");
//Console.WriteLine($"Car: {e.Make} - {e.Model} - {e.Price.ToString("C")}");
//Console.WriteLine($"There are {Car.numOfCars} cars in the CLASS");

//Store s = new Store();
//s.ShoppingList.Add(c);
//s.ShoppingList.Add(d);

//numOfCarsInCart = s.ShoppingList.Count;
//decimal total = s.CheckOut();

//Console.WriteLine($"Total Cost for {numOfCarsInCart} cars is {total.ToString("C")}");