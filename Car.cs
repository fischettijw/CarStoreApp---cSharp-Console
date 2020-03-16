using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp___cSharp_Console
{
    public class Car
    {
        public static int numOfCars;
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            this.Make = "nothing";
            this.Model = "nothing";
            this.Price = 0.00m;
            numOfCars = 0;
        }

        public Car(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            numOfCars += 1;
        }
    }
}
