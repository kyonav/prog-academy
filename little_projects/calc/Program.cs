namespace little_projects;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        string[] operHistory = new string[100];

        int histCounter = 0;
        // prints the menu, then redirects to the selected option
        string userInput = showMenu();

        Console.Clear();

        //prints the mult table of a choosen number
        if (userInput == "5"){
            Console.Clear();

            Console.WriteLine(" >>> Multiplication table <<");
            Console.WriteLine();

            Console.Write("Type a number > ");

            int num = 0;
            num = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int counter = 1; counter <= 10; counter++){
                int tabResult = num * counter;
                Console.WriteLine($"{num} x {counter} = {tabResult}");

            } 

            Console.WriteLine();

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            Console.Clear();

        }

        // prints the history operation
        if (userInput == "6"){
            if (operHistory[0] != null){
                Console.Clear();

                Console.WriteLine(">>> Operation history <<<");
                Console.WriteLine();

                foreach (string item in operHistory){
                    if (item != null){
                        Console.WriteLine(item);

                    }
                }
                Console.WriteLine();

                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();

                Console.Clear();


            } else {
                Console.Clear();

                Console.WriteLine("The history is empty.");
                Console.WriteLine();


            }
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
            result = firstNumber + secondNumber;
            operHistory[histCounter] = $"{firstNumber} + {secondNumber} = {result}";

        } else if (userInput == "2"){
            result = firstNumber - secondNumber;
            operHistory[histCounter] = $"{firstNumber} - {secondNumber} = {result}";

        } else if (userInput == "3"){
            result = firstNumber * secondNumber;
            operHistory[histCounter] = $"{firstNumber} * {secondNumber} = {result}";

        } else if (userInput == "4"){
            result = firstNumber / secondNumber;
            operHistory[histCounter] = $"{firstNumber} / {secondNumber} = {result}";

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
}
