using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; set; }
        public double FuelConsumptionInLitresKM { get; set; }


        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumptionInLitresKM = fuelConsumption;
        }

        public void Drive(double km)
        {
            double newFuelAmount = FuelQuantity - FuelConsumptionInLitresKM * km;
            if (newFuelAmount < 0)
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            else
            {
                FuelQuantity = newFuelAmount;
                Console.WriteLine($"{this.GetType().Name} travelled {km} km");
            }
        }

        public virtual void Refuel(double liters)
        {
            FuelQuantity += liters;
        }

        public override string ToString()
            => $"{this.GetType().Name}: {FuelQuantity:f2}";
    }
}
