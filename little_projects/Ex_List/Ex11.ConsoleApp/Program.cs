namespace Ex11.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your name > ");
            string name = Console.ReadLine()!;
            Console.WriteLine();

            Console.Write("How old are you? > ");
            int age = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.WriteLine($"{name}, you are {age * 365} days old.");
        }
    }
}
