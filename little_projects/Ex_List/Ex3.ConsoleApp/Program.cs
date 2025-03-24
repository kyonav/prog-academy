namespace Ex3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inital mileage > ");
            double initial = double.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("Final mileage > ");
            double final = double.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("Fuel consumed > ");
            double fConsumed = double.Parse(Console.ReadLine()!);
            Console.WriteLine();

            double mileageTraveled = (final - initial);

            double consumptionPerKm = (mileageTraveled / fConsumed);

            Console.WriteLine($"The fuel consumption during the route was ~ {consumptionPerKm} km/L");
        }
    }
}
