using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildLab10_25_UsedCarLot
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }
        public Car(string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }
        public override string ToString()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nPrice: ${Price}";
        }

    }
}
