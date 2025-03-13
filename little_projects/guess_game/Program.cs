namespace guess_game;

class Program
{
    static void Main(string[] args)
    {
        do {
            Console.Clear();

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("><------------>< g u e s s _ g a m e ><------------><");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("1 (Start)"); // double quote ( " ) is used on string
            Console.WriteLine();            // single quote ( ' ) is used on char


            Console.WriteLine("2 (Exit)");
            Console.WriteLine();

            Console.Write("> ");
            string? userInput = (Console.ReadLine());

            if (!char.TryParse(userInput, out char cvChar)){
                Console.WriteLine($"[{userInput}] <-- (empty char) is not a valid option. Try again.");
                // (gambiarra)
                // for some reason this doesn't work with exactly one space input
                // but if it is none or more than 1 space it does work
                //
                continue;

            }

            if (userInput == "1"){
                Console.Clear();

                int totalt;
                do {
                    Console.WriteLine("--->< Choose the difficulty level ><---");
                    Console.WriteLine();
                    
                    Console.WriteLine("(1) Easy [6 tries]");
                    Console.WriteLine("(2) Medium [4 tries]");
                    Console.WriteLine("(3) Hard [2 tries]");
                    Console.WriteLine();

                    Console.Write("> ");
                    string diffLevel = Console.ReadLine();

                    Console.Clear();

                    switch (diffLevel){
                        case "1":
                            totalt = 6;
                            break;

                        case "2":
                            totalt = 4;
                            break;

                        case "3":
                            totalt = 2;
                            break;

                        default:
                            Console.Clear();

                            Console.WriteLine("Invalid option. Try again.");
                            Console.WriteLine();

                            continue;

                    }
                    
                    break; 

                } while (true);

                Random num = new Random();
                int rng = num.Next(1, 16);

                for (int triesLimit = 0; totalt > triesLimit; totalt--){
                    int thisTry = 1;

                    Console.WriteLine($"--->< Try number {thisTry} >< {totalt} remaining ><---");
                    Console.WriteLine();

                    Console.Write("Your guess here > ");
                    int userGuess = Int32.Parse(Console.ReadLine());
                    //Console.WriteLine(userGuess);

                    Console.Clear();

                    Console.WriteLine("___________________________________________");
                    Console.WriteLine();

                    if (userGuess == rng){
                        break;

                    } else if (userGuess > rng){
                        Console.WriteLine($"The random number is lower than {userGuess}");

                    } else if (userGuess < rng){
                        Console.WriteLine($"The random number is higher than {userGuess}");

                    } else {
                        Console.Clear();

                        Console.WriteLine("You provided a invalid input. Try again.");
                        totalt++;

                    }   

                    Console.WriteLine("___________________________________________");
                    Console.WriteLine();


                    thisTry++;
                }

                if (totalt == 0){
                    Console.Clear();

                    Console.WriteLine("___________________________________________");
                    Console.WriteLine();
                    Console.WriteLine("You didn't guessed right and ran out of tries.");
                    Console.WriteLine($"The random number was {rng}.");
                    Console.WriteLine("___________________________________________");
                    Console.WriteLine();

                } else {
                    Console.Clear(); 

                    Console.WriteLine("___________________________________________");
                    Console.WriteLine();
                    Console.WriteLine($"Nice, you got it! the random number was {rng}.");
                    Console.WriteLine("___________________________________________");
                    Console.WriteLine();

                }

                Console.WriteLine("> What do you wish to do now? <");
                Console.WriteLine();
                Console.WriteLine("(1) Go to menu");
                Console.WriteLine();

                Console.WriteLine("(2) Force quit");
                Console.WriteLine();

                Console.Write("> ");
                userInput = Console.ReadLine();

                if (userInput == "1"){
                    continue; 

                } else if (userInput == "2"){
                    Console.Clear();

                    Console.WriteLine("Closing the program...");
                    break;

                }


            } else if (userInput == "2"){
                Console.Clear();

                Console.WriteLine("Closing the program...");
                return;

            } else {
                Console.WriteLine($"[{userInput}] <-- is not a valid option. Try again.");
                continue;

            }

        } while (true);
    }
}
