using System;

namespace Inheritance
{
    public class Cessna : PetrolVehicle
    {  // Propellor light aircraft

        public double Wingspan { get; set; }

        // Overrides the inherited method Drive and replaces with new
        public override void Drive()
        {
            Console.WriteLine("The plane goes 'BZZZZZZ'");
        }
    }
}