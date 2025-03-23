namespace DiceRaceGame.ConsoleApp;

internal class DiceRaceGame
{

    public static void AppMenuMain()
    {
        Console.WriteLine("_________________________________________");
        Console.WriteLine();
        Console.WriteLine(" Low budget Dice Race Game!");
        Console.WriteLine();
        Console.WriteLine(" (1) Start");
        Console.WriteLine(" (2) Help");
        Console.WriteLine();
        Console.WriteLine(" (0) Quit");
        Console.WriteLine("_________________________________________");
        Console.WriteLine();

        Console.WriteLine("_________________________________________");
        Console.WriteLine();
        Console.WriteLine(" What do you wish to do? (1, 2 or 0)");
        Console.Write(" > ");
        string userInput = Console.ReadLine()!;
        Console.WriteLine();

        if (userInput != null)
        {
            if (userInput == "1")
            {
                AppMenuRun();
            }
            else if (userInput == "2")
            {
                AppMenuHelp();
            }
            else if (userInput == "0")
            {
                Console.Clear();

                Console.WriteLine("________________________");
                Console.WriteLine();
                Console.WriteLine(" Exiting program...");
                Console.WriteLine("________________________");
                Console.WriteLine();

                Environment.Exit(0);
            }
            else
            {
                Console.Clear();

                Console.WriteLine("________________________________");
                Console.WriteLine();
                Console.WriteLine(" Invalid option. Try again.");
                Console.WriteLine("________________________________");
                Console.WriteLine();

                AppMenuMain();
            }
        }
        else
        {
            Console.Clear();

            Console.WriteLine("_____________________________________");
            Console.WriteLine();
            Console.WriteLine(" Null input detected. Try again.");
            Console.WriteLine("_____________________________________");
            Console.WriteLine();

            AppMenuMain();
        }
    }

    public static void AppMenuRun()
    {
        int newPlayerPos = 0; int newCpuPos = 0;
        string[] playerNCpuPosArray = new string[30];

        do
        {
            do
            {
                Console.Clear();

                Console.WriteLine("___________________________");
                Console.WriteLine();
                Console.WriteLine(" Press (ENTER) to rng!");
                Console.WriteLine("___________________________");
                Console.WriteLine();

            } while (Console.ReadKey().Key != ConsoleKey.Enter);

            for (int i = 0; i < playerNCpuPosArray.Length; i++)
            {
                playerNCpuPosArray[i] = " ___ ";
            }

            int playerRng = RunRollDice();
            newPlayerPos += playerRng;

            int cpuRng = RunRollDice();
            newCpuPos += cpuRng;

            Console.WriteLine($" Player rolled {playerRng} | Player unit > {newPlayerPos}");
            Console.WriteLine();
            Console.WriteLine($" CPU rolled {cpuRng} | CPU unit > {newCpuPos}");
            Console.WriteLine();

            RunEventCheckerDraw(newPlayerPos, newCpuPos);

            RunCheckIfGameEnded(newPlayerPos, newCpuPos);

            newCpuPos = UpdatePlayerNCpuPosArrayCpu(playerNCpuPosArray, newCpuPos);                  
            newPlayerPos = UpdatePlayerNCpuPosArrayPlayer(playerNCpuPosArray, newPlayerPos);
            
            playerNCpuPosArray = UpdatePlayerNCpuPosArrayIdem(playerNCpuPosArray, newPlayerPos, newCpuPos);

            foreach (string stringChar in playerNCpuPosArray)
                {
                    Console.Write(stringChar);
                }

            Console.WriteLine();

            for (int unit = 0; unit < playerNCpuPosArray.Length; unit++)
            {
                int unitPrint = unit;

                if (unit < 9)
                {
                    Console.Write($" 0{unitPrint + 1}  ");
                }
                else if (unit < 16)
                {
                    Console.Write($" {unitPrint + 1}  ");
                }
                else
                {
                    Console.Write($"  {unitPrint + 1} ");
                }
            }

            do
            {
                Console.WriteLine();
                Console.WriteLine("___________________________________");
                Console.WriteLine();
                Console.WriteLine(" Press (ENTER) tgt next round.");
                Console.WriteLine("___________________________________");
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
        } while (true);
    }

    public static void AppMenuHelp()
    {
        Console.Clear();

        Console.WriteLine("____________________________________________");
        Console.WriteLine();
        Console.WriteLine(" Under construction. Try on next patch.");
        Console.WriteLine("____________________________________________");
        Thread.Sleep(2000);

        Console.Clear();
        AppMenuMain();
    }

    public static int RunRollDice()
    {
        Random num = new Random();
        int rngNum = num.Next(1, 7);

        //int rngNum = Random.Next(1, 7);

        return rngNum;
    }

    public static int UpdatePlayerNCpuPosArrayPlayer(string[] playerNCpuPosArray, int playerPos)
    {

        for (int value = 0; value < playerNCpuPosArray.Length; value++)
        {
            if (value == playerPos)
            {
                if (playerNCpuPosArray[playerPos] == " ___ ")
                {
                    playerPos = RunEventCheckerPlayer(playerPos);
                    int constPlayerPos = playerPos;
                    playerNCpuPosArray[constPlayerPos -1] = " _*_ ";
                }
            } 
        }
        return playerPos;
    }

    public static int UpdatePlayerNCpuPosArrayCpu(string[] playerNCpuPosArray, int cpuPos)
    {
        for (int value = 0; value < playerNCpuPosArray.Length; value++)
        {
            if (value == cpuPos)
            {
                if (playerNCpuPosArray[cpuPos] == " ___ ")
                {
                    cpuPos = RunEventCheckerCpu(cpuPos);
                    int constCpuPos = cpuPos;
                    playerNCpuPosArray[constCpuPos - 1] = " _+_ ";
                }
            }
        }
        return cpuPos;
    }

    public static string[] UpdatePlayerNCpuPosArrayIdem(string[] playerNCpuPosArray, int newPlayerPos, int newCpuPos)
    {
        for (int value = 0; value < playerNCpuPosArray.Length; value++)
        {
            if (newPlayerPos == newCpuPos)
            {
                int constValue = newPlayerPos;
                playerNCpuPosArray[constValue -1] = " _~_ ";

                Console.WriteLine(" Player and CPU are on the same unit!");
                break;

            }
        }
        return playerNCpuPosArray;
    }

    public static int RunEventCheckerPlayer(int playerPos)
    {
        // andvance event
        switch (playerPos)
        {
            case 5:
                playerPos += 4;
                Console.WriteLine(" (Player) Advance event found! plus 4");
                break;

            case 10:
                playerPos += 4;
                Console.WriteLine(" (Player) Advance event found! plus 4");

                break;

            case 15:
                playerPos += 2;
                Console.WriteLine(" (Player) Advance event found! plus 2");

                break;

            case 25:
                playerPos += 1;
                Console.WriteLine(" (Player) Advance event found! plus 1");
                break;
        }

        // return event
        switch (playerPos)
        {
            case 7:
                playerPos -= 2;
                Console.WriteLine(" (Player) Return event found! less 2");
                break;

            case 13:
                playerPos -= 3;
                Console.WriteLine(" (Player) Return event found! less 3");
                break;

            case 20:
                playerPos -= 4;
                Console.WriteLine(" (Player) Return event found! less 4");
                break;
        }
        return playerPos;
    }

    public static int RunEventCheckerCpu(int cpuPos)
    {
        // advance event
        switch (cpuPos)
        {
            case 5:
                cpuPos += 4;
                Console.WriteLine(" (CPU) Advance event found! plus 4");
                break;

            case 10:
                cpuPos += 4;
                Console.WriteLine(" (CPU) Advance event found! plus 4");
                break;

            case 15:
                Console.WriteLine(" (CPU) Advance event found! plus 2");
                cpuPos += 2;
                break;

            case 25:
                cpuPos += 1;
                Console.WriteLine(" (CPU) Advance event found! plus 1");
                break;
        }

        // return event
        switch (cpuPos)
        {
            case 7:
                cpuPos -= 1;
                Console.WriteLine(" (CPU) Return event found! less 1");
                break;

            case 13:
                cpuPos -= 2;
                Console.WriteLine(" (CPU) Return event found! less 2");
                break;

            case 20:
                cpuPos -= 3;
                Console.WriteLine(" (CPU) Return event found! less 3");
                break;
        }
        return cpuPos;
    }

    public static void RunEventCheckerDraw(int playerPos, int cpuPos)
    {
        if (playerPos == 26 && cpuPos == 26) // in the gui it'll show that 27 is the draw
        {
            Console.WriteLine("_________________________________________________________");
            Console.WriteLine();
            Console.WriteLine(" Both ended up on position number 27. The game draw.");
            Console.WriteLine("_________________________________________________________");

            AppMenuEnd();
        }
    }

    public static void RunCheckIfGameEnded(int newPlayerPos, int newCpuPos)
    {
        if (newPlayerPos >= 30)
        {
            Console.WriteLine("_____________________________________________");
            Console.WriteLine();
            Console.WriteLine(" Player got to 30 first! > Player Won! <");
            Console.WriteLine("_____________________________________________");

            AppMenuEnd();

        }
        else if (newCpuPos >= 30)
        {
            Console.WriteLine("_______________________________________");
            Console.WriteLine();
            Console.WriteLine(" Cpu got to 30 first! > Cpu Won! <");
            Console.WriteLine("_______________________________________");

            AppMenuEnd();

        }
    }

    public static void AppMenuEnd()
    {
        Console.WriteLine("_____________________________");
        Console.WriteLine();
        Console.WriteLine(" > Game ended <");

        Console.WriteLine();

        Console.WriteLine(" Press (ENTER) tgt menu.");
        Console.WriteLine("_____________________________");

        if (Console.ReadKey().Key != ConsoleKey.Enter)
        {
            Console.Clear();

            Console.WriteLine("_____________________________");
            Console.WriteLine();
            Console.WriteLine(" Invalid key. try again.");
            Console.WriteLine("_____________________________");

            AppMenuEnd();
        } else
        {
            Console.Clear();
            Program.Main();
        }
    }
}
