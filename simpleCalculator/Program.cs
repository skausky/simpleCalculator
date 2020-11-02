using System;

namespace simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Multiplication");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Subtraction \n");
            int action = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter input one: ");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter input two: ");
            int inputTwo = Convert.ToInt32(Console.ReadLine());

            int answer = 0;

            switch (action)
            {
                case 1:
                    {
                        answer = Addition(inputOne, inputTwo);
                        break;
                    }
                case 2:
                    {
                        answer = Multiplication(inputOne, inputTwo);
                        break;
                    }
                case 3:
                    {
                        answer = Divison(inputOne, inputTwo);
                        break;
                    }
                case 4:
                    {
                        answer = Subtract(inputOne, inputTwo);
                        break;
                    }
            }

            Console.WriteLine("\nYour answer is: " + answer);
            Console.WriteLine("\nPress enter to end the program");
            Console.Read();
        }
        public static int Addition(int inputOne, int inputTwo)
        {
            int answer = inputOne + inputTwo;
            return answer;
        }
        public static int Multiplication(int inputOne, int inputTwo)
        {
            int answer = inputOne * inputTwo;
            return answer;
        }
        public static int Divison(int inputOne, int inputTwo)
        {
            int answer = inputOne / inputTwo;
            return answer;
        }
        public static int Subtract(int inputOne, int inputTwo)
        {
            int answer = inputOne - inputTwo;
            return answer;
        }
    }
}
