using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._2
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Fuel { get; set; }
        public double HorsePower { get; set; }
        public int Km { get; set; }
        public int Year { get; set; }
        
        public Car(string brand, string model, double fuel, double horsepower, int km, int year)
        {
            Brand = brand;
            Model = model;
            Fuel = fuel;
            HorsePower = horsepower;
            Km = km;
            Year = year;
        }

        public void Drive()
        {
            Console.WriteLine($"Car {Brand} {Model} is driving at fullspeed all the way down the highway!");
        }

        public void IncreaseKilometrage()
        {
            Km++;   
        }

        public override string ToString()
        {
            return $"Car {Brand} {Model} produced in {Year} has passed {Km}. Used fuel: {Fuel}, Available HP: <horsePower>.";
        }
    }
}
 