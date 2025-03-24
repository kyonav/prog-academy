namespace Ex2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the radius > ");
            double radius = double.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("Type the height > ");
            double height = double.Parse(Console.ReadLine()!);
            Console.WriteLine();

            double result = Math.PI * Math.Pow(radius, 2) * height;

            Console.WriteLine($"The cilinder volume is > {result}");
        }
    }
}
