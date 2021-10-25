using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildLab10_25_UsedCarLot
{
    class UsedCar : Car
    {
        public UsedCar() : base()
        { }
        public UsedCar(string Make, string Model, int Year, decimal Price, double Mileage) : base(Make, Model, Year, Price)
        { }
        public double Mileage { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nMileage: {Mileage}";
        }
    }
}
