namespace Ex7.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test score 1 > ");
            float test1 = float.Parse(Console.ReadLine()!);
            Console.Write("Score 1 weight > ");
            float weight1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("Test score 2 > ");
            float test2 = float.Parse(Console.ReadLine()!);
            Console.Write("Score 2 weight > ");
            float weight2 = float.Parse(Console.ReadLine()!);

            float wa = (((test1 * weight1) + (test2 * weight2)) / (weight1 + weight2));

            Console.WriteLine($"The weighted average is {wa}");
        }
    }
}
