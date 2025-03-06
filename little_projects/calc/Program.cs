namespace little_projects;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Limited calc");
        Console.WriteLine();

        Console.WriteLine("1 - Sum");
        Console.WriteLine("2 - Subtract");
        Console.WriteLine();
        Console.WriteLine("Q - Quit");

        string userInput = Console.ReadLine().ToUpper();

        if (userInput == "Q"){
            return;

        }     

        Console.Write("Type the 1st number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Type the 2nd number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int result = 0;
        if (userInput == "1"){
            result = firstNumber + secondNumber;

        } else if (userInput == "2"){
            result = firstNumber - secondNumber;

        }

        Console.WriteLine(result);

    }
}
