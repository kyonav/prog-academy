namespace Ex12.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in your salary > ");
            float userSalary = float.Parse(Console.ReadLine()!);
            Console.WriteLine();

            float userSalaryIncreased = (userSalary + (userSalary * 0.15f));
            float userSalaryPostTaxes = (userSalaryIncreased - (userSalaryIncreased * 0.08f));

            Console.Clear();

            Console.WriteLine($"Your past salary was {userSalary}");
            Console.WriteLine($"Your salary post 15% increase is {userSalaryIncreased}");
            Console.WriteLine($"Your new salary after -8% in taxes > {userSalaryPostTaxes} <");

        }
    }
}
