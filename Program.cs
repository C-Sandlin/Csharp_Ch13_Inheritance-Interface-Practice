using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var tesla = new Tesla()
            {
                MainColor = "red",
                MaximumOccupancy = 5,
                TouchScreenWidth = 10.8,
                BatteryKWh = 300.57
            };

            var zero = new Zero()
            {
                MainColor = "red",
                MaximumOccupancy = 5,
                OdometerSize = 3.4,
                BatteryKWh = 300.57
            };

            var cessna = new Cessna()
            {
                MainColor = "red",
                MaximumOccupancy = 5,
                Wingspan = 20,
                FuelCapacity = 100.50
            };

            var ram = new Ram()
            {
                MainColor = "red",
                MaximumOccupancy = 5,
                BedLength = 8,
                FuelCapacity = 30.50
            };

            ram.Drive();
            cessna.Drive();
            zero.Drive();
            tesla.Drive();

            tesla.Facts();
        }
    }
}
