using System;

namespace Lab_1st_Assignment
{
    class Program
    {
        // The conosle App is guess the number
        static void Main(string[] args)
        { 

            int n;
            char again;

            do
            {
                Console.WriteLine("Enter you choice (0 to 10)");
                n = int.Parse(Console.ReadLine());

                checkNum(n);

                Console.WriteLine("\nDo You want to try again(y/n)?");
                again = char.Parse(Console.ReadLine());

                Console.Clear();

            } while (again == 'y' || again == 'Y');

        }

        public static int  randomNum()
        {
            Random rnd = new Random();

            return rnd.Next(10);
        }

        public static void checkNum(int n)
        {
            int randNum = randomNum();

            if (n == randNum)
            {
                Console.WriteLine($"You Won, The Number is {randNum}");
            }
            else Console.WriteLine($"You Lost, The Number Was {randNum}");
        }
    }
}
