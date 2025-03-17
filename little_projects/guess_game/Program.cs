using System.ComponentModel.Design;

namespace guess_game;

class Program
{
    static void Main(string[] args)
    {
        // if 1, start game
        do
        {
            if (Functions.PrintMenuMain() == "1")
            {
                Functions.StartGameMain(Functions.PrintMenuDifficulty());

            }
            else if (Functions.PrintMenuMain() == "2")
            {
                Console.WriteLine("Closing program...");
                return;

            }

        } while (true);
    }
}
