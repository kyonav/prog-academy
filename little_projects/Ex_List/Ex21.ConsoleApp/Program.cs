using System.Runtime.ExceptionServices;

namespace Ex21.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a number > ");
            int number = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine();

            int updatedNumber = number;

            for (int n = number; n > 1; n--)
            {
                updatedNumber = updatedNumber * (n - 1);

                Console.WriteLine($"{n} x {n -1} = {updatedNumber}");
            }
            

        }
    }
}
