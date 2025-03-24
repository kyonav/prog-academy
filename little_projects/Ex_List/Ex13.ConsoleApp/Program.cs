namespace Ex13.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the value of A > ");
            int a = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("Insert the value of B > ");
            int b = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("Insert the value of C > ");
            int c = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine();

            if (a + b < c)
            {
                Console.WriteLine($"{a} + {b} is smaller than {c}");
            } else
            {
                Console.WriteLine($"{a} + {b} is equal or bigger than {c}");
            }

        }
    }
}
