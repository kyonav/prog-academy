namespace Ex10.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float frenchBreadPrice = 0.12f;
            float cornBreadPrice = 1.50f;

            Console.Write("How many french bread were sold? > ");
            int frenchBreadQtt = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("How many cornbread were sold? > ");
            int cornBreadQtt = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine();

            float selledFrenchBread = (frenchBreadPrice * frenchBreadQtt);
            float selledCornBread = (cornBreadPrice * cornBreadQtt);

            float totalSelled = (selledFrenchBread + selledCornBread);
            float ammountToSave = (totalSelled * 0.10f);

            Console.WriteLine($"You selled {frenchBreadQtt} breads, and {cornBreadQtt} cornbreads.");
            Console.WriteLine($"You made {totalSelled} dollars today.");
            Console.WriteLine();

            Console.WriteLine($"Youh should invest 10%, which is exactly {ammountToSave}.");
        }
    }
}
