namespace Ex6.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Grade 1 > ");
            float grade1 = float.Parse(Console.ReadLine()!);

            Console.Write("Grade 2 > ");
            float grade2 = float.Parse(Console.ReadLine()!);

            Console.Write("Grade 3 > ");
            float grade3 = float.Parse(Console.ReadLine()!);

            Console.Write("Grade 4 > ");
            float grade4 = float.Parse(Console.ReadLine()!);

            float hm = (4 / ((1 / grade1) + (1 / grade2) + (1 / grade3) + (1 / grade4)));

            Console.WriteLine($"The harmonic medium of {grade1}, {grade2}, {grade3} and {grade4} is {hm}");
        }
    }
}
