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

            if (Functions.GameMenuMain() == "2")
            {
                int errorsQtt = 0;
                string foundWord = "";

                do
                {

                    Functions.PrintGameMain(errorsQtt, foundLetters, randomWord);
                    char userInput = AskForUserInputIngame();
                    errorsQtt = Functions.CheckIfLetterWasFound(randomWord, userInput, foundLetters, errorsQtt);
                    foundWord = Functions.MountWordByChar(foundWord, foundLetters);
                    Functions.PlayerWonLose(foundWord, randomWord, errorsQtt);      
                    
                } while (true);               
            }
            else if (Functions.GameMenuMain() == "2")
            {
                Functions.ExitProgram();
            }
            else
            {
                Functions.InputTreatment(Console.ReadLine()!);
                Main(); 
            }
        }

        // user interactions on main
        public static string AskForUserInputMenu()
        {
            Console.WriteLine();

            Console.Write("> ");
            string userInput = Console.ReadLine()!;
            return Functions.InputTreatment(userInput) ? userInput : "a";

           
        }

        public static char AskForUserInputIngame()
        {
            Console.WriteLine();

            Console.Write("> ");
            char userGuessChar = Char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine(userGuessChar);
            Console.ReadLine();

            return userGuessChar;
        }
    }
}
