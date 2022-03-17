using System;

namespace Igor.Class03.Homework.Task01.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfInput = 6;
            int[] numbers = new int[numbersOfInput];
            int result = 0;

            for (int i = 0; i < numbersOfInput; i++)
            {
                Console.WriteLine("Enter your " + (i+1) + " number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                numbers[i] = input;
                if(numbers[i] % 2 == 0)
                {
                    result += numbers[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
