namespace Ex9.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the length? > ");
            float length = float.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("What is the width? > ");
            float width = float.Parse(Console.ReadLine()!);
            Console.WriteLine();

            if (length == width)
            {
                Console.WriteLine("Not a rectangle.");
            } else
            {
                Console.WriteLine($"The area is {length * width}.");

            }
        }
    }
}
