namespace Ex22.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number > ");
            int n = Int32.Parse(Console.ReadLine()!);

            int a = 0, b = 1;
            while (a <= n)
            {
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }
        }    
    }
}
