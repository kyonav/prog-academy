namespace knowledge_test;

class Program
{
    static void Main(string[] args)
    {

        static void app_menu_help(){
            Console.Clear();
            
            Console.Write("Loading help...");
            Thread.Sleep(1500);

            Console.Clear();

            do {
                Console.Write("In order for this program to work ");
                Console.Write("correctly, you need to follow the existance ");
                Console.Write("condition. Ex:");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("X + Y > Z");
                Console.WriteLine("Y + Z > X");
                Console.WriteLine("X + Z > Y");
                Console.WriteLine();

                Console.WriteLine("1 - Main menu");
                Console.WriteLine();

                Console.Write("> ");

                if (Int32.TryParse(Console.ReadLine(), out int userInput)){
                    if (userInput == 1){
                        app_menu_main();

                    } else {
                        Console.Clear();
                        Console.WriteLine("Invalid option. Try again...");
                        Console.WriteLine();

                    }

                } else {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Type only numbers...");
                    Console.WriteLine();

                }

            } while (true);
        }


        static void app_menu_main(){
            Console.Clear();

            Console.WriteLine("Loading menu...");
            Thread.Sleep(1500);

            Console.Clear();

            do {
                Console.WriteLine(">>> Triangle classifier <<<");
                Console.WriteLine();

                Console.WriteLine("1 - Start");
                Console.WriteLine("2 - Help");
                Console.WriteLine();
                Console.WriteLine("0 - Quit");
                Console.WriteLine();
                
                Console.Write("> ");

                if (Int32.TryParse(Console.ReadLine(), out int userInput)){
                    if (userInput == 1){
                        app_start_def();

                    } else if (userInput == 2){
                        app_menu_help(); 

                    } else if (userInput == 0){
                        Console.Clear();

                        Console.WriteLine("Quitting...");
                        Thread.Sleep(1500);

                        break;

                    } else {
                        Console.Clear();

                        Console.WriteLine("Invalid option. Try again...");
                        Console.WriteLine();
                    }

                } else {
                    Console.Clear();

                    Console.WriteLine("Invalid input. Type only numbers...");
                    Console.WriteLine();

                }

            } while (true);
        }

        static void app_menu_end(){
            do {
                Console.WriteLine();

                Console.WriteLine("1 - Try again");
                Console.WriteLine("2 - Main menu");
                Console.WriteLine();

                Console.Write("> ");

                if (Int32.TryParse(Console.ReadLine(), out int userInput)){
                    if (userInput == 1){
                        Console.Clear();

                        app_start_def();

                    } else if (userInput == 2){
                        Console.Clear();

                        app_menu_main();

                    } else {
                        Console.Clear();

                        Console.WriteLine("Invalid option. Try again...");

                    }

                } else {
                    Console.Clear();

                    Console.WriteLine("Invalid input. Type only numbers...");

                }

            } while (true);
        }

        static void app_start_def(){
            Console.Clear();

            Console.WriteLine("Loading app...");
            Thread.Sleep(1500);

            Console.Clear();

            string[] valuesChar = new string[3] {"X", "Y", "Z"};        
            int[] valuesNum = new int[3];
            
            do {
                for (int index = 0; index < valuesNum.Length;){

                    Console.WriteLine($"Input the {valuesChar[index]} value.");
                    Console.Write("> ");

                    if (Int32.TryParse(Console.ReadLine(), out valuesNum[index])){
                        index++;

                    } else {
                        Console.Clear();

                        Console.WriteLine("Invalid input. Type only numbers.");
                        Console.WriteLine();
                    }
                }

                //foreach (int item in valuesNum){
                //    Console.WriteLine(item);
                //}

                if ((valuesNum[0] + valuesNum[1]) > valuesNum[2] &&
                     (valuesNum[1] + valuesNum[2]) > valuesNum[0] &&
                     (valuesNum[0] + valuesNum[2]) > valuesNum[1]){

                    string userOutput;
                    if (valuesNum[0] == valuesNum[1] && valuesNum[0] == valuesNum[2]){
                        userOutput = "equilateral"; 

                    } else if (valuesNum[0] == valuesNum[1]) {
                        userOutput = "isosceles";

                    } else if (valuesNum[1] == valuesNum[2]){
                        userOutput = "isosceles";

                    } else if (valuesNum[0] == valuesNum[2]){
                        userOutput = "isosceles";

                    } else {
                        userOutput = "scalene";

                    }

                    Console.Clear();

                    Console.WriteLine($"Your triangle is > {userOutput} <");

                } else {
                    Console.Clear();

                    Console.WriteLine("Invalid triangle. Try again...");
                    Console.WriteLine();

                    continue;

                }

                app_menu_end();

            } while (true);
        }
        
        app_menu_main();
    }
}
