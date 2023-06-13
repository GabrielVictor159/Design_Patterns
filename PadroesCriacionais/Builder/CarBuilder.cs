using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;

namespace Design_Patterns.PadroesCriacionais.Builder
{
    public class CarBuilder
    {
        private string brand { get; set; }
        private string model { get; set; }
        private int year { get; set; }
        private string color { get; set; }
        private string type { get; set; }

        public static CarBuilder New(Faker faker)
        {
            return new CarBuilder()
            {
                brand = faker.Vehicle.Manufacturer(),
                model = faker.Vehicle.Model(),
                year = faker.Random.Int(1990, 2023),
                color = faker.Commerce.Color(),
                type = faker.Vehicle.Type()
            };
        }
        public CarBuilder WithBrand(string brand)
        {
            this.brand = brand;
            return this;
        }

        public CarBuilder WithModel(string model)
        {
            this.model = model;
            return this;
        }

        public CarBuilder WithYear(int year)
        {
            this.year = year;
            return this;
        }

        public CarBuilder WithColor(string color)
        {
            this.color = color;
            return this;
        }
        public CarBuilder WithType(string type)
        {
            this.type = type;
            return this;
        }
        public Car Build()
        {
            return new Car(brand, model, year, color, type);
        }


    }
}