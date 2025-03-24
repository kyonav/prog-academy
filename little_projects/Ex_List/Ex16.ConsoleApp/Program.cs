namespace Ex16.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number > ");
            int num = Int32.Parse(Console.ReadLine()!);

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even");
            } else
            {
                Console.WriteLine($"{num} is odd");
            }
        }
    }
}
