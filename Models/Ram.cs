using System;

namespace Inheritance
{
    public class Ram : PetrolVehicle
    {  // Propellor light aircraft

        public double BedLength { get; set; }

        // Overrides the inherited method Drive and replaces with new
        public override void Drive()
        {
            Console.WriteLine("The Ram goes 'BRRRRRRRRRT'");
        }
    }
}