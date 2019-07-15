using System;

namespace Inheritance
{
    public class PetrolVehicle : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine($"The {FuelCapacity} gallon tank is refueling!");
        }


    }
}