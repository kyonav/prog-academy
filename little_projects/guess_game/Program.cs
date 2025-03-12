namespace guess_game;

class Program
{
    static void Main(string[] args)
    {
        do {
            Console.Clear();

            Console.WriteLine("--->< g u e s s _ g a m e ><---");
            Console.WriteLine();

            Console.WriteLine("Continue? Y/N");
            Console.Write("> ");

            string userInput = Console.ReadLine().ToUpper();

            int maxTries = 0;
            if (userInput == "Y"){
                Console.Clear();

                Console.WriteLine("Difficulty level");
                Console.WriteLine();

                Console.WriteLine("1 - Easy (5 tries)");
                Console.WriteLine("2 - Medium (3 tries)");
                Console.WriteLine("3 - Hard (1 try)");

                Console.Write("> ");
                string diffLevel = Console.ReadLine();

                Random genNum = new Random();
                int rndNumber = genNum.Next(1, 11);

                if (diffLevel == "1"){
                    maxTries = 5;

                } else if (diffLevel == "2"){
                    maxTries = 3;

                } else if (diffLevel == "3"){
                    maxTries = 1;

                } else {
                    Console.Clear();

                    Console.WriteLine("Invalid input. Try again.");
                    Console.WriteLine();
                    continue;

                }

                Console.Clear();

                for (int tt = maxTries; tt > 0; tt--){
                    Console.WriteLine($">>> {tt} try(ies) remaining <<<");
                    Console.WriteLine();

                    Console.Write("Type a number > ");
                    int typedNumber = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();

                    //Console.WriteLine($"You typed the number {typedNumber}");
                    //Console.WriteLine($"The random number is {rndNumber}");
                    //Console.WriteLine();

                    Console.Clear();

                    if (typedNumber < rndNumber){
                        Console.WriteLine($"[Rng number is bigger than {typedNumber}]");
                        Console.WriteLine();

                    } else if (typedNumber > rndNumber){
                        Console.WriteLine($"[Rng number is smaller than {typedNumber}]");
                        Console.WriteLine();

                    } else if (typedNumber == rndNumber){
                        Console.WriteLine($"[You got it! Number was {rndNumber}]");
                        Console.WriteLine();

                        Console.WriteLine("1 - Play again");
                        Console.WriteLine("2 - Quit");
                        Console.Write("> ");

                        if (Console.ReadLine() == "1"){
                            break; 

                        } else if (Console.ReadLine() == "2"){
                            Console.Clear();

                            Console.WriteLine("Quitting...");
                            return;

                        } else {
                            Console.Clear();

                            Console.WriteLine("Invalid option. Try again.");

                        }

                    } else {
                        Console.WriteLine("Nope, try again.");

                    }

                }

                if (maxTries == 0){
                    do {
                        Console.WriteLine("You ran out of tries. Restart? Y/N");
                        Console.Write("> ");

                        if (Console.ReadLine() == "Y"){
                            break;

                        } else if (Console.ReadLine() == "N"){
                            Console.Clear();

                            Console.WriteLine("Quitting...");
                            return;

                        } else {
                            Console.Clear();

                            Console.WriteLine("Invalid input. Try again.");
                            Console.WriteLine();

                            continue;

                        }

                    } while (true);
                }

            } else if (userInput == "N"){
                Console.Clear();
                
                Console.WriteLine("Quitting...");
                return;

            } else {
                Console.WriteLine("Invalid option. Try again");
                continue;

            }



        } while (true);
    }
}
