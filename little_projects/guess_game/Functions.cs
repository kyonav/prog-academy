using System;
using System.Reflection.Metadata.Ecma335;

namespace guess_game
{
    static class Functions
    {
        public static string PrintMenuMain()
        {
            do
            {
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

                if (userInput != "1" && userInput != "2")
                {
                    Console.Clear();

                    Console.WriteLine("Invalid input. Try again.");
                    Console.WriteLine();

                    continue;

                } else
                {
                    Console.Clear();
                    return userInput;

                }               
            } while (true);
        }

        public static string PrintMenuDifficulty()
        {
            Console.WriteLine("--->< Choose the difficulty level ><---");
            Console.WriteLine();

            Console.WriteLine("(1) Easy [6 tries]");
            Console.WriteLine("(2) Medium [4 tries]");
            Console.WriteLine("(3) Hard [2 tries]");
            Console.WriteLine();

            Console.Write("> ");
            string? diffLevel = Console.ReadLine();

            switch (diffLevel)
            {
                case "1":
                    diffLevel = "6";
                    break;

                case "2":
                    diffLevel = "4";
                    break;

                case "3":
                    diffLevel = "2";
                    break;

                default:
                    Console.Clear();

                    Console.WriteLine("Invalid input. Try again.");
                    Console.WriteLine();

                    PrintMenuDifficulty();
                    break;
                }
            return diffLevel;
        }


        public static int RandomNumberGenerator()
        {
            Random num = new Random();
            int rng = num.Next(1, 16);

            return rng;
        }

        public static void StartGameMain(string diffLevel)
        {
            Console.Clear();

            int rng = RandomNumberGenerator();

            int totalt = Int32.Parse(diffLevel);

            for (int triesLimit = 0; totalt > triesLimit; totalt--)
            {
                int thisTry = 1;

                Console.WriteLine($"--->< Try number {thisTry} >< {totalt} remaining ><---");
                Console.WriteLine();

                Console.Write("Your guess here > ");

                string userGuessString;
                int userGuessInt;

                try
                {
                    userGuessString = (Console.ReadLine());


                    if (userGuessString != null)
                    {
                        userGuessInt = Convert.ToInt32(userGuessString);
                        
                    } else
                    {
                        Console.Clear();
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("Invalid input. Try again");
                        Console.WriteLine("___________________________________________");

                        Console.WriteLine();

                        totalt++;
                        continue;
                    }

                }
                catch (FormatException) // otavio sabe de muito pprt
                {
                    Console.Clear();

                    Console.WriteLine("___________________________________________");
                    Console.WriteLine();

                    Console.WriteLine("Invalid input. Try again");
                    Console.WriteLine("___________________________________________");
                    Console.WriteLine();

                    totalt++;
                    continue;
                    
                }
                
                //Console.WriteLine(userGuess);
               
                Console.Clear();

                Console.WriteLine("___________________________________________");
                Console.WriteLine();

                if (userGuessInt == rng)
                {
                    Console.WriteLine($"You won, the random number was {rng}!");
                    Console.WriteLine();

                }
                else if (userGuessInt > rng)
                {
                    Console.WriteLine($"The random number is lower than {userGuessInt}");

                }
                else if (userGuessInt < rng)
                {
                    Console.WriteLine($"The random number is higher than {userGuessInt}");

                }

                Console.WriteLine("___________________________________________");
                Console.WriteLine();

                thisTry++;
            }    

            if (totalt == 0)
            {
                Console.Clear();

                Console.WriteLine("___________________________________________");
                Console.WriteLine();
                Console.WriteLine("You didn't guessed right and ran out of tries.");
                Console.WriteLine($"The random number was {rng}.");
                Console.WriteLine("___________________________________________");
                Console.WriteLine();

            }

            Console.Write("Press enter to continue > ");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Going back to menu...");
            Thread.Sleep(1500);

            Console.Clear();
        }

//        public static string PrintMenuEndgame()
//        {
//            Console.WriteLine("> What do you wish to do now? <");
//            Console.WriteLine();
//            Console.WriteLine("(1) Go to menu");
//            Console.WriteLine();

//            Console.WriteLine("(2) Force quit");
//            Console.WriteLine();

//            Console.Write("> ");
//            string userInput = Console.ReadLine();


//            return userInput;
//        }
    }
}