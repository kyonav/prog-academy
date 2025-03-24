namespace Ex19.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 500; num++)
            {
                if (num % 2 != 0 && num % 3 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
