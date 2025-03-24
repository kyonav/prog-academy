namespace Ex20.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a number > ");
            int n = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine();

            for (int t = 1; t <= 10; t++)
            {
                Console.WriteLine($"{n} x {t} = {n * t}");
            }
        }
    }
}
