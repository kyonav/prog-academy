namespace hangman_game {
    internal class Program {
        static void Main(string[] args){
            string[] words = {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "ABACATE",
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

            Random random = new Random();

            int randomIndex = random.Next(words.Length);

            string randomWord = words[randomIndex];

            char[] foundLetters = new char[randomWord.Length];

            for (int c= 0; c < foundLetters.Length; c++){
                foundLetters[c] = '_';

            }

            int errorsQtt = 0;
            bool playerHang = false;
            bool playerGuessed = false;

            do{
                string playerHead = errorsQtt >= 1 ? " o " : " ";
                string body = errorsQtt >= 2 ? "x" : " ";
                string lowBody = errorsQtt >= 2 ? " x " : " ";
                string leftArm = errorsQtt >= 3 ? "/" : " ";
                string rightArm = errorsQtt >= 4 ? @"\" : " ";
                string legs = errorsQtt >= 5 ? "/ \\" : " ";

                Console.Clear();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Hangman Game!");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(" ___________        ");
                Console.WriteLine(" |/        |        ");
                Console.WriteLine(" |        {0}       ", playerHead);
                Console.WriteLine(" |        {0}{1}{2} ", leftArm, body, rightArm);
                Console.WriteLine(" |        {0}       ", lowBody);
                Console.WriteLine(" |        {0}       ", legs);
                Console.WriteLine(" |                  ");
                Console.WriteLine(" |                  ");
                Console.WriteLine("_|____              ");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Guessed letters: " + errorsQtt);
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Choose word: " + String.Join("", foundLetters));
                Console.WriteLine("----------------------------------------------");

                Console.Write("Type a letter: ");
                char guess = Console.ReadLine()!.ToUpper()[0];

                bool letterWasFound = false;

                for (int counter = 0; counter < randomWord.Length; counter++){
                    char thisLetter = randomWord[counter];

                    if (guess == thisLetter){
                        foundLetters[counter] = thisLetter;
                        letterWasFound = true;

                    }
                }

                if (letterWasFound  == false){
                    errorsQtt++;
                    
                }

                string foundWord  = String.Join("", foundLetters);

                playerGuessed = foundWord == randomWord;
                playerHang = errorsQtt > 5;

                if (playerGuessed){
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine($"You got it! the random word was {randomWord}.");
                    Console.WriteLine("----------------------------------------------");

                }

                else if (playerHang){
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Unlucky! Try again!");
                    Console.WriteLine("----------------------------------------------");

                }

            } while (playerHang == false && playerGuessed == false);
        }
    }
}
