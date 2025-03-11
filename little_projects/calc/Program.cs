namespace little_projects;

class Program
{
    static void Main(string[] args)
    {
        string[] operHistory = new string[100];

        int histCounter = 0;
        while (true){
            Console.WriteLine("Limited calc");
            Console.WriteLine();

            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Multiply");
            Console.WriteLine("4 - Divide");
            Console.WriteLine("5 - Mult table");
            Console.WriteLine("6 - History");
            Console.WriteLine();
            Console.WriteLine("Q - Quit");
            Console.WriteLine();

            string userInput = Console.ReadLine().ToUpper();

            if (userInput == "5"){
                Console.Clear();

                Console.WriteLine("Multiplication table");
                Console.WriteLine();

                Console.Write("Type a number > ");

                int num = 0;
                num = Int32.Parse(Console.ReadLine());

                for (int counter = 1; counter <= 10; counter++){
                    int tabResult = num * counter;
                    Console.WriteLine($"{num} x {counter} = {tabResult}");

                } 


               Console.ReadLine();
               continue;
            }

            if (userInput == "6"){
                foreach (string item in operHistory){
                    if (item != null){
                        Console.WriteLine(item);

                    }
                }
            }

            Console.Write("Type the 1st number: ");
            float firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type the 2nd number: ");
            float secondNumber = Convert.ToInt32(Console.ReadLine());

            if (secondNumber == 0 && userInput == "4"){
                Console.WriteLine("Cannot divide by zero.");
                continue;

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

            }

            histCounter++;

            Console.WriteLine();
            Console.WriteLine("Result > ");
            Console.WriteLine(result.ToString("F2"));
            Console.WriteLine();

            Console.Write("Continue? Y/N > ");
            if (Console.ReadLine() != "Y"){
                break;

            }
        }
    }
}
