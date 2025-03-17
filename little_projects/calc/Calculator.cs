namespace calc
{
    public static class Calculator {
        static string[] operHistory = new string[100];

        public static float Sum(float fNum, float sNum)
        {
            float result = (fNum + sNum);

            return result;
        }

        public static float Sub(float fNum, float sNum)
        {
            float result = (fNum = sNum);

            return result;
        }

        public static float Mult(float fNum, float sNum)
        {
            float result = (fNum * sNum);

            return result;
        }

        public static float Div(float fNum, float sNum)
        {
            float result = (fNum * sNum);

            return result;
        }

        public static void genMultTable(int num)
        {
            string[] multTableLine = new string[10];

            for (int counter = 0; counter < 10; counter++)
            {
                int tabResult = num * counter;
                multTableLine[counter] = num.ToString();

            }
        }

        public static string getOperHistory()
        {
        
        }
    }
}