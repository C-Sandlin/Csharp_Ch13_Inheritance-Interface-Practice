using System;
using System.Collections.Generic;

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

            // INTERFACES

            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla ModelS = new Tesla();

            List<IChargeable> ElectricTransports = new List<IChargeable>()
            {
                fxs, fx, ModelS
            };

            Cessna myCessna = new Cessna();
            Cessna yourCessna = new Cessna();
            Ram myRam = new Ram();

            List<IRefuelable> GasTransports = new List<IRefuelable>()
            {
                myCessna, yourCessna, myRam
            };



        }
    }
}
