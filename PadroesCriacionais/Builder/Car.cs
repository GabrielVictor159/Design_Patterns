using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.PadroesCriacionais.Builder
{
    public class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public int Year { get; }
        public string Color { get; }
        private string Type { get; }

        public Car(string brand, string model, int year, string color, string type)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            Type = type;
        }

        public void DisplayInfo(int index)
        {
            Console.WriteLine($"Car {index}:");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"-------------------------------------------");
        }
    }
}