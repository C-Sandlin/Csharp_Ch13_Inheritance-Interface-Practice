namespace Inheritance
{
    public interface IRefuelable
    {
        double FuelCapacity { get; set; }
        void RefuelTank();
    }
}