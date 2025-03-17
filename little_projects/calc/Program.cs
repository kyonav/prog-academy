namespace calc;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        

        int histCounter = 0;
        // prints the menu, then redirects to the selected option
        string userInput = showMenu();

        Console.Clear();

        //prints the mult table of a choosen number
        if (userInput == "5"){
            Console.Clear();

            Console.WriteLine(" >>> Multiplication table <<");
            Console.WriteLine();

            

        }

        // prints the history operation
        if (userInput == "6"){
            
        }

        // checks if the user wants to quit
        if (userChooseToQuit(userInput)){
            Console.Clear();

            Console.WriteLine("Quitting...");
            return;
        }

        Console.Write("Type the 1st number > ");
        float firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Type the 2nd number > ");
        float secondNumber = Convert.ToInt32(Console.ReadLine());

        if (secondNumber == 0 && userInput == "4"){
            Console.WriteLine("Cannot divide by zero.");

        }

        float result = 0;
        if (userInput == "1"){
            result = Calculator.Sum(firstNumber, secondNumber);

        } else if (userInput == "2"){
            result = Calculator.Sub(firstNumber, secondNumber);

        } else if (userInput == "3"){
            result = Calculator.Mult(firstNumber, secondNumber);

        } else if (userInput == "4"){
            result = Calculator.Div(firstNumber, secondNumber);

        } else {
            Console.Clear();

            Console.WriteLine("Invalid option. Try again.");

        }

        histCounter++;

        Console.WriteLine();
        Console.Write("Result > ");
        Console.WriteLine(result.ToString("F2"));
        Console.WriteLine();

        Console.Write("Continue? Y/N > ");
        if (Console.ReadLine() != "Y"){
            Console.Clear();

            Console.WriteLine("Quitting...");

        }

        Console.Clear();
    }

    static string showMenu(){
        while (true){
            Console.WriteLine(">>> Low budget calculator <<<");
            Console.WriteLine();

            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Multiply");
            Console.WriteLine("4 - Divide");
            Console.WriteLine();

            Console.WriteLine("5 - Mult table");
            Console.WriteLine("6 - History");
            Console.WriteLine();
            Console.WriteLine("Q - Quit");
            Console.WriteLine();

            Console.Write("> ");
            string userInput = Console.ReadLine().ToUpper();
            return userInput;

        }
    }

    static bool userChooseToQuit(string opt){
        bool userChooseToQuit = opt == "Q";
        
        return userChooseToQuit;

    }

    static bool()
    {

    }
}
