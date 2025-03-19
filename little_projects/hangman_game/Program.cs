namespace hangman_game
{
    internal class Program
    {
        internal static void Main()
        {
            //returning array values
            string[] wordsArray = Functions.WordsArray();
            string randomWord = Functions.RandomWordPicker(wordsArray);
            char[] foundLetters = Functions.FoundLettersArray(randomWord);

            int errorsQtt = 0;
            string foundWord = "";
            
            Functions.GameMenuMain();
            string userInputString = AskForUserInputMenu();

            Console.Clear();

            if (userInputString == "1")
            {
                do
                {
                Functions.PrintGameMain(errorsQtt, foundLetters, randomWord);

                char userInput = AskForUserInputIngame();
                errorsQtt = Functions.CheckIfLetterWasFound(randomWord, userInput, foundLetters, errorsQtt);
                foundWord = Functions.MountWordByChar(foundWord, foundLetters);
                Functions.PlayerWonLose(foundWord, randomWord, errorsQtt);

                Console.Clear();

                } while (true);
                    
            }

                else if (userInputString == "2")
                {
                    Console.WriteLine("Closing program...");
                    return;
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("Invalid input. Try again.");
                    Main();
                }

            
        }

        // user interactions on main
        public static string AskForUserInputMenu()
        {
            Console.WriteLine();

            Console.Write("> ");
            string userInput = Console.ReadLine()!;

            return userInput;
           
        }

        public static char AskForUserInputIngame()
        {
            Console.WriteLine();

            Console.Write("> ");
            char userGuessChar = Char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine(userGuessChar);

            return userGuessChar;
        }
    }
}
