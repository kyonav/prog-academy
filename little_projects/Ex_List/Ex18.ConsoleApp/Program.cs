using System.Runtime.CompilerServices;

namespace Ex18.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num = 100; num <= 200; num++)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
