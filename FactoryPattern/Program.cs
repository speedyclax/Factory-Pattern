namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 or 4 for the number of tires for your vehicle:");
            int wheelCount = int.Parse(Console.ReadLine());

            var vehicle = VehicleFactory.GetVehicle(wheelCount);

            vehicle.Drive();
        }
    }
}
