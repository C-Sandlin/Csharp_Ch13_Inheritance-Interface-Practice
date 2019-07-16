using System;

namespace Inheritance
{
    public class Zero : ElectricVehicle
    {  // Electric motorcycle

        public double OdometerSize { get; set; }
        // Overrides the inherited method Drive and replaces with new
        public override void Drive()
        {
            Console.WriteLine("The zero goes 'WSSSSSSS'");
        }
    }
}