namespace Ex14.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three different values;");
            Console.WriteLine();

            Console.Write("Value 1 > ");
            int a = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("Value 2 > ");
            int b = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("Value 3 > ");
            int c = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine();

            if (a > b && a > c)
            {
                if (b > c)
                    Console.WriteLine($"{a} > {b} > {c}");
                else
                    Console.WriteLine($"{a} > {c} >{b}");
            }
            else if (b > a && b > c)
            {
                if (a > c)
                    Console.WriteLine($"{b} > {a} >{c}");
                else 
                    Console.WriteLine($"{b} > {c} > {a}");
            }
            else
            {
                if (a > b)
                    Console.WriteLine($"{c} > {a} > {b}");
                else
                    Console.WriteLine($"{c} >{b} > {a}");
            }
        }
    }
}
