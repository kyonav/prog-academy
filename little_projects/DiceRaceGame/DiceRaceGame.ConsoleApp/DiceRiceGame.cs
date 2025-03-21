using System.Runtime.ExceptionServices;
using System.Text;

namespace DiceRaceGame.ConsoleApp;
// zvaI TOMAR NO CU 
internal class DiceRaceGame
{
    public static void MenuRun()
    {
        int newPlayerPos = 0; int newCpuPos = 0;

        do
        {
            string[] playerNCpuPosArray = new string[30];

            int playerRng = RunRollDice();
            newPlayerPos += playerRng;

            int cpuRng = RunRollDice();
            newCpuPos += cpuRng;

            Console.WriteLine();
            Console.WriteLine("_______________________________________");
            Console.WriteLine();
            Console.WriteLine("Press any key to rng");
            Console.WriteLine("_______________________________________");
            Console.WriteLine();

            Console.ReadLine();
            Console.WriteLine($"Player rolled {playerRng} | Player unit > {newPlayerPos}");
            Console.WriteLine();
            Console.WriteLine($"CPU rolled {cpuRng} | CPU unit > {newCpuPos}");
            Console.WriteLine();

            newPlayerPos = UpdatePlayerNCpuPosArrayPlayer(playerNCpuPosArray, newPlayerPos);
            newCpuPos = UpdatePlayerNCpuPosArrayCpu(playerNCpuPosArray, newCpuPos);

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
        } while (true);
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
            if (value != playerPos)
            {
                playerNCpuPosArray[value] = " ___ ";
            } else
            {             
                if (playerPos == value)
                {
                    playerPos = RunEventCheckerPlayer(playerPos);
                    int constPlayerPos = playerPos;
                    playerNCpuPosArray[constPlayerPos -1] = " _*_ ";
                }
            }
        }
        return playerPos;
    }

    public static void storeCpuChar()
    {

    }

    public static int UpdatePlayerNCpuPosArrayCpu(string[] playerNCpuPosArray, int cpuPos)
    {
        for (int value = 0; value < playerNCpuPosArray.Length; value++)
        {


            if (value != cpuPos)
            {
                playerNCpuPosArray[value] = " ___ ";
            }
            else
            {
                if (cpuPos == value)
                {
                    
                    cpuPos = RunEventCheckerCpu(cpuPos);
                    int constCpuPos = cpuPos;
                    playerNCpuPosArray[constCpuPos -1] = " _+_ ";
                }
            }
        }
        return cpuPos;
    }

    public static int RunEventCheckerPlayer(int playerPos)
    {
        // andvance event
        switch (playerPos)
        {
            case 5:
                playerPos += 4;
                Console.WriteLine("(Player) Advance event found! plus 4");
                break;

            case 10:
                playerPos += 4;
                Console.WriteLine("(Player) Advance event found! plus 4");

                break;

            case 15:
                playerPos += 2;
                Console.WriteLine("(Player) Advance event found! plus 2");

                break;

            case 25:
                playerPos += 1;
                Console.WriteLine("(Player) Advance event found! plus 1");
                break;
        }

        // return event
        switch (playerPos)
        {
            case 7:
                playerPos -= 2;
                Console.WriteLine("(Player) Return event found! less 2");
                break;

            case 13:
                playerPos -= 3;
                Console.WriteLine("(Player) Return event found! less 3");
                break;

            case 20:
                playerPos -= 4;
                Console.WriteLine("(Player) Return event found! less 4");
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
                Console.WriteLine("(CPU) Advance event found! plus 4");
                break;

            case 10:
                cpuPos += 4;
                Console.WriteLine("(CPU) Advance event found! plus 4");
                break;

            case 15:
                Console.WriteLine("(CPU) Advance event found! plus 2");
                cpuPos += 2;
                break;

            case 25:
                cpuPos += 1;
                Console.WriteLine("(CPU) Advance event found! plus 1");
                break;
        }

        // return event
        switch (cpuPos)
        {
            case 7:
                cpuPos -= 1;
                Console.WriteLine("(CPU) Return event found! less 1");
                break;

            case 13:
                cpuPos -= 2;
                Console.WriteLine("(CPU) Return event found! less 2");
                break;

            case 20:
                cpuPos -= 3;
                Console.WriteLine("(CPU) Return event found! less 3");
                break;
        }
        return cpuPos;
    }

    public static bool RunEventCheckerDraw(int playerPos, int cpuPos)
    {
        if (playerPos == 26 && cpuPos == 26) // in the gui it'll show that 27 is the draw
        {
            Console.WriteLine("Both ended up on position number 27. The game draw.");
            return true;
        }
        else
        {
            return false;
        }
    }
}
