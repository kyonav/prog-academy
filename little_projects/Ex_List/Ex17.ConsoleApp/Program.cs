namespace Ex17.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the A value > ");
            int a = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.WriteLine("Enter the B value > ");
            int b = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine();

            int c;

            if (a == b)
            {
                c = (a + b);
            } else
            {
                c = (a * b);
            }

            Console.WriteLine($"The value of C is {c}");
        }
    }
}
