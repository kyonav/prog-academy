namespace Ex4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature in Celsius > ");
            float celsius = float.Parse(Console.ReadLine()!);
            Console.WriteLine();

            float convertToFahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"{celsius}°C > is > {convertToFahrenheit}°F");
        }
    }
}
