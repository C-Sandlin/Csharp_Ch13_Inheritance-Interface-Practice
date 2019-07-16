using System;

namespace Inheritance
{
    public class PetrolVehicle : Vehicle, IRefuelable
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine($"The {FuelCapacity} gallon tank is refueling!");
        }


    }
}