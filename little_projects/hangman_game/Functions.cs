using Microsoft.VisualBasic;

namespace hangman_game
{
    internal class Functions
    {
        public static string[] WordsArray()
        {
            string[] arrayOfWords = {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
            };
            return arrayOfWords;
        }

        public static string RandomWordPicker(string[] arrayOfWords)
        {
            Random random = new Random();

            int randomIndex = random.Next(arrayOfWords.Length);
            string randomWord = arrayOfWords[randomIndex];
            return randomWord;
        }

        public static char[] FoundLettersArray(string randomWord)
        {
            char[] foundLetters = new char[randomWord.Length];

            for (int c = 0; c < foundLetters.Length; c++)
            {
                foundLetters[c] = '_';

            }
            return foundLetters;
        }

        // console display and var storage on functions
        public static string GameMenuMain()
        {
            Console.WriteLine("______________________________________________");
            Console.WriteLine();

            Console.WriteLine("HangMan GOTY");
            Console.WriteLine("______________________________________________");
            Console.WriteLine();

            Console.WriteLine("(1) Play");
            Console.WriteLine();

            Console.WriteLine("(2) Exit");
            Console.WriteLine("______________________________________________");

            return Program.AskForUserInputMenu();
        }

        public static void PrintGameMain(int errorsQtt, char[] foundLetters, string randomWord)
        {
            string playerHead = errorsQtt >= 1 ? " o " : " ";
            string body = errorsQtt >= 2 ? "x" : " ";
            string lowBody = errorsQtt >= 2 ? " x " : " ";
            string leftArm = errorsQtt >= 3 ? "/" : " ";
            string rightArm = errorsQtt >= 4 ? @"\" : " ";
            string legs = errorsQtt >= 5 ? "/ \\" : " ";

            Console.WriteLine("______________________________________________");
            Console.WriteLine();

            Console.WriteLine("Hangman Game!");
            Console.WriteLine("______________________________________________");
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/        |        ");
            Console.WriteLine(" |        {0}       ", playerHead);
            Console.WriteLine(" |        {0}{1}{2} ", leftArm, body, rightArm);
            Console.WriteLine(" |        {0}       ", lowBody);
            Console.WriteLine(" |        {0}       ", legs);
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");
            Console.WriteLine("______________________________________________");
            Console.WriteLine();

            Console.WriteLine("Tries Remaining: " + (errorsQtt + 1));
            Console.WriteLine("______________________________________________");
            Console.WriteLine();

            Console.WriteLine("Choose word: " + String.Join("", foundLetters));
            Console.WriteLine("______________________________________________");
            // for debugging purposes
            //Console.WriteLine(randomWord);
        }

        public static string MountWordByChar(string foundWord, char[] foundLetters)
        {
            foundWord = String.Join("", foundLetters);

            return foundWord;
        }

        public static int CheckIfLetterWasFound(string randomWord, char userInput, char[] foundLetters, int errorsQtt)
        {
            bool letterWasFound = false;

            for (int counter = 0; counter < randomWord.Length; counter++)
            {
                char thisLetter = randomWord[counter];

                if (userInput == thisLetter)
                {
                    foundLetters[counter] = thisLetter;
                    letterWasFound = true;
                }
            }

            if (!letterWasFound)
            {
                errorsQtt++;
            }

            return errorsQtt;
        }

        public static void PlayerWonLose(string foundWord, string randomWord, int errorsQtt)
        {
            bool playerGuessed = foundWord == randomWord;
            bool playerHang = errorsQtt > 4;

            if (playerGuessed)
            {
                Console.Clear();

                Console.WriteLine("______________________________________________");
                Console.WriteLine();

                Console.WriteLine($"You Won! the word was {randomWord}");
                Console.WriteLine("______________________________________________");
                Console.WriteLine();

                Program.Main();

            }
            else if (playerHang)
            {
                Console.Clear();

                Console.WriteLine("______________________________________________");
                Console.WriteLine();

                Console.WriteLine($"You Lost. the word was {randomWord}");
                Console.WriteLine("______________________________________________");
                Console.WriteLine();

                Program.Main();

            }
        }

        public static bool InputTreatment(string userInput)
        {

            if (userInput != null)
            {
                if (Int32.TryParse(userInput, out _))
                {
                    return true;
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("Invalid input. Try again.");
                    Program.Main(); return false;      
                    // nao sei como isso aq faz o menor sentido
                    // so sei q se eu tiro o program.main ele 
                    // da readline 2x kk              
                }
            }
            else
            {

                Console.Clear();

                Console.WriteLine("Null input detected. Try again.");
                Program.Main(); return false;
            }
        }

        public static void ExitProgram()
        {
            Console.Clear();
            
            Console.WriteLine("______________________________________________");
            Console.WriteLine();

            Console.WriteLine("Closing program...");
            Console.WriteLine("______________________________________________");

            return;
        }
    }
}
