using System.Diagnostics;

namespace triangle_classifier
{
    class TriangleClassifier
    {
        public static void AppMenuMain()
        {
            Console.WriteLine("__________________________________");
            Console.WriteLine();
            Console.WriteLine(" Loading menu...");
            Console.WriteLine("__________________________________");

            Thread.Sleep(1500);

            Console.Clear();

            Console.WriteLine("__________________________________");
            Console.WriteLine();
            Console.WriteLine(" >>> Triangle Classifier <<<");
            Console.WriteLine();

            Console.WriteLine(" 1 - Start");
            Console.WriteLine(" 2 - Help");
            Console.WriteLine();
            Console.WriteLine(" 0 - Quit");
            Console.WriteLine("__________________________________");
            Console.WriteLine();

            Console.Write(" > ");
        }

        public static void AppRunStart()
        {
            Console.Clear();

            Console.WriteLine("__________________________________");
            Console.WriteLine();
            Console.WriteLine(" Loading app...");
            Console.WriteLine("__________________________________");

            Thread.Sleep(1500);

            Console.Clear();
        }

        public static int[] AppRunUserInput()
        {
            string[] valuesChar = new string[3] { "X", "Y", "Z" };
            int[] valuesNum = new int[3];

            do
            {
                for (int index = 0; index < valuesNum.Length;)
                {
                    Console.WriteLine("__________________________________");
                    Console.WriteLine();
                    Console.WriteLine($" Input the {valuesChar[index]} value.");
                    Console.WriteLine("__________________________________");
                    Console.WriteLine();
                    Console.Write("> ");

                    string userInput = Console.ReadLine();
                    if (Int32.TryParse(userInput, out valuesNum[index]))
                    {
                        index++;
                    }
                    else
                    {
                        InvalidInputLog();
                    }
                }

                //foreach (int item in valuesNum){
                //    Console.WriteLine(item);
                //}

                return valuesNum;
            } while (true);
        }

        public static void AppRunTriangleVerification(int[] valuesNum)
        {
            if ((valuesNum[0] + valuesNum[1]) > valuesNum[2] &&
                     (valuesNum[1] + valuesNum[2]) > valuesNum[0] &&
                     (valuesNum[0] + valuesNum[2]) > valuesNum[1])
            {

                string userOutput;
                if (valuesNum[0] == valuesNum[1] && valuesNum[0] == valuesNum[2])
                {
                    userOutput = "equilateral";
                }
                else if (valuesNum[0] == valuesNum[1])
                {
                    userOutput = "isosceles";
                }
                else if (valuesNum[1] == valuesNum[2])
                {
                    userOutput = "isosceles";
                }
                else if (valuesNum[0] == valuesNum[2])
                {
                    userOutput = "isosceles";
                }
                else
                {
                    userOutput = "scalene";
                }

                Console.Clear();

                Console.WriteLine("__________________________________");
                Console.WriteLine();
                Console.WriteLine($" Your triangle is > {userOutput} <");
                Console.WriteLine("__________________________________");

            }
            else
            {
                Console.Clear();

                Console.WriteLine("__________________________________");
                Console.WriteLine();
                Console.WriteLine(" Invalid triangle. Try again...");
                Console.WriteLine("__________________________________");

                Console.WriteLine();

                
                AppRunTriangleVerification(AppRunUserInput());
                AppMenuEnd();
            }

        }

        public static void AppMenuHelp()
        {
            Console.Clear();

            Console.WriteLine("__________________________________");
            Console.WriteLine();
            Console.WriteLine(" Loading help...");
            Console.WriteLine("__________________________________");

            Thread.Sleep(1500);

            Console.Clear();

            do
            {
                Console.WriteLine("__________________________________");
                Console.WriteLine();
                Console.Write(" In order for this program to work \n " +
                    "correctly, you need to follow the \n " +
                    "'existance condition' below.");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine(" X + Y > Z");
                Console.WriteLine(" Y + Z > X");
                Console.WriteLine(" X + Z > Y");
                Console.WriteLine("__________________________________");
                Console.WriteLine();


                Console.WriteLine(" 1 - Main menu");
                Console.WriteLine();

                Console.Write(" > ");

                string userInput = Console.ReadLine()!;

                if (Int32.TryParse(userInput, out _))
                {
                    if (userInput == "1")
                    {
                        Console.Clear();

                        Program.Main();
                    }
                    else
                    {
                        InvalidOptionLog();
                    }
                }
                else
                {
                    InvalidInputLog();
                }
            } while (true);
        }

        public static string AppMenuEnd()
        {
            Console.WriteLine();
            Console.WriteLine("__________________________________");
            Console.WriteLine();
            Console.WriteLine(" 1 - Main Menu");
            Console.WriteLine("__________________________________");
            Console.WriteLine();

            Console.Write(" > ");

            string userInput = Console.ReadLine();


            if (Int32.TryParse(userInput, out _))
            {

                if (userInput == "1")
                {
                    Console.Clear();

                    Program.Main();
                }                             
                else
                {
                    InvalidOptionLog();
                }
            }
            else
            {
                InvalidInputLog();
            }
            return userInput;
        }
   
        public static void InvalidInputLog()
        {
            Console.Clear();

            Console.WriteLine("__________________________________");
            Console.WriteLine();
            Console.WriteLine(" Invalid input. Type only numbers...");
            Console.WriteLine("__________________________________");
            Console.WriteLine();
        }

        public static void InvalidOptionLog()
        {
            Console.Clear();
            Console.WriteLine("__________________________________");
            Console.WriteLine();
            Console.WriteLine(" Invalid option. Try again...");
            Console.WriteLine("__________________________________");
            Console.WriteLine();
        }
    }
}
