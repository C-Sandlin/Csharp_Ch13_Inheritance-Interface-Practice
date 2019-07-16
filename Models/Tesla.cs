using System;

namespace Inheritance
{
    public class Tesla : ElectricVehicle
    {
        public double TouchScreenWidth { get; set; }

        // Overrides the inherited method Drive and replaces with new
        public override void Drive()
        {
            Console.WriteLine("The tesla goes '......'");
        }

        public void Facts()
        {
            Console.WriteLine($"The Tesla has a touch screen that is {TouchScreenWidth} inches wide. The Battery holds a charge of {BatteryKWh} KWh's, and it seats {MaximumOccupancy} people");
        }
    }
}