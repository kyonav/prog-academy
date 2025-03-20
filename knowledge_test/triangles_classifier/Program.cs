using System.Reflection.Metadata.Ecma335;

namespace triangle_classifier;

internal class Program
{
    public static void Main() // surely this can be public, right?
    {
        TriangleClassifier.AppMenuMain();

        string userInput = Console.ReadLine();
        if (Int32.TryParse(userInput, out _))
        {

            if (userInput == "1")
            {
                    TriangleClassifier.AppRunStart();
                    int[] valuesNumArray = TriangleClassifier.AppRunUserInput();
                    TriangleClassifier.AppRunTriangleVerification(valuesNumArray);
                    TriangleClassifier.AppMenuEnd();


            }
            else if (userInput == "2")
            {
                TriangleClassifier.AppMenuHelp();
            }
            else if (userInput == "0")
            {
                Console.Clear();

                Console.WriteLine("Closing app...");
                Environment.Exit(0);
            }
            else
            {
                TriangleClassifier.InvalidOptionLog();
                Main();
            }
        }
        else
        {
            TriangleClassifier.InvalidInputLog();
            Main();
        }
    }
}
