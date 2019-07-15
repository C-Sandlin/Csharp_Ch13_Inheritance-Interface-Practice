using System;

namespace Inheritance
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        // to allow a child to overwrite, add "virtual"
        public virtual void Drive()
        {
            Console.WriteLine($"The vehicle is driving");
        }
    }
}