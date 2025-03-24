using System.Data;
using System.Runtime.InteropServices;

namespace Ex15.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight > ");
            float weight = float.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.WriteLine("Enter your height > ");
            float height = float.Parse(Console.ReadLine()!);
            Console.WriteLine();

            float imc = (weight / (float)Math.Pow(height, 2));

            Console.WriteLine($"Your IMC is {imc}");
            Console.WriteLine();

            if (imc < 18.5)
            {
                Console.WriteLine("You are underweight");
            } else if (imc < 25)
            {
                Console.WriteLine("You have normal weight");
            } else if (imc < 30)
            {
                Console.WriteLine("You are overweight");
            } else
            {
                Console.WriteLine("You are obese");
            }
        }
    }
}
