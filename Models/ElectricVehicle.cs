using System;

namespace Inheritance
{
    public class ElectricVehicle : Vehicle, IChargeable
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"The {BatteryKWh} KWh battery is charging...");
        }
    }
}