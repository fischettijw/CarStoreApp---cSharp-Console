using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp___cSharp_Console
{
    public class Store
    {
           public static string prePrint = "";

        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }

        public Store()
        {
            this.CarList = new List<Car>();
            this.ShoppingList = new List<Car>();
        }

        public decimal CheckOut()
        {
            decimal totalCost = 0.00m;

            foreach (Car c in ShoppingList)
            {
                totalCost += c.Price;
            }

            ShoppingList.Clear();
            return totalCost;
        }

        public override string ToString()
        {
            string carsInCart = "";
            foreach (Car car in CarList)
            {
                Car.prePrint = "";
                carsInCart += prePrint + car + "\n";
            }
            return carsInCart;
        }

    }
}
