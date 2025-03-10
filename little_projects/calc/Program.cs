namespace little_projects;

class Program
{
    static void Main(string[] args)
    {

        bool shouldRun = true;

        while (shouldRun == true){
            Console.Clear();

            Console.WriteLine("Limited calc");
            Console.WriteLine();

            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Multiply");
            Console.WriteLine("4 - Divide");
            Console.WriteLine();
            Console.WriteLine("Q - Quit");
            Console.WriteLine();

            string userInput = Console.ReadLine().ToUpper();

            if (userInput == "Q"){
                return;

            }     

            Console.Write("Type the 1st number: ");
            float firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type the 2nd number: ");
            float secondNumber = Convert.ToInt32(Console.ReadLine());

            float result = 0;
            if (userInput == "1"){
                result = firstNumber + secondNumber;

            } else if (userInput == "2"){
                result = firstNumber - secondNumber;

            } else if (userInput == "3"){
                result = firstNumber * secondNumber;

            } else if (userInput == "4"){
                    result = firstNumber / secondNumber;

            }

            if (secondNumber == 0){
                Console.WriteLine("Cannot divide by zero.");
                continue;

            }

            Console.WriteLine(result.ToString("F2"));
            Console.WriteLine();

            Console.Write("Continue? Y/N > ");
            if (Console.ReadLine() != "Y"){
                break;

            }
        }


    }
}
