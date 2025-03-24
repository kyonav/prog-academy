namespace Ex5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inform your salary > $");
            float baseSalary = float.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("How much did you sell? (money amount) > $");
            float salesTotal = float.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("What is the current comission percentage? > ");
            float comissionPercent = float.Parse(Console.ReadLine()!);
            Console.WriteLine();

            float calcComission = (salesTotal * comissionPercent) / 100;

            float salaryPlusComission = (baseSalary + calcComission);

            Console.WriteLine($"Your base salary > ${baseSalary}");
            Console.WriteLine($"Your total sales > ${salesTotal}");
            Console.WriteLine($"Comission (per total sales) > {comissionPercent}%");
            Console.WriteLine();
            Console.WriteLine($"Your salary + comission is ${salaryPlusComission}");


        }
    }
}
