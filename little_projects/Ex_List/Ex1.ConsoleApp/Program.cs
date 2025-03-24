namespace Ex1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the length > ");
            int length = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("Type the height > ");
            int width = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("Type the width > ");
            int height = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.WriteLine($"The volume is {length * width * height}");
        }
    }
}
