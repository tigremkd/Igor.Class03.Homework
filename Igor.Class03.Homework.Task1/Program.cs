using System;

namespace Igor.Class03.Homework.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first num");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Enter second num");
            string secondInput = Console.ReadLine();
            Console.WriteLine("Enter third num");
            string thirdInput = Console.ReadLine();
            Console.WriteLine("Enter fourth  num");
            string fourthInput = Console.ReadLine();
            Console.WriteLine("Enter fifth  num");
            string fifthInput = Console.ReadLine();
            Console.WriteLine("Enter sixth  hnum");
            string sixthInput = Console.ReadLine();
            

            bool isFirstValid = int.TryParse(firstInput, out int firstValid);
            bool isSecondValid = int.TryParse(secondInput, out int secondValid);
            bool isThirdValid = int.TryParse(thirdInput, out int thirdValid);
            bool isFourthValid = int.TryParse(fourthInput, out int fourthValid);
            bool isFifthValid = int.TryParse(fifthInput, out int fifthValid);
            bool isSixthValid = int.TryParse(sixthInput, out int sixthValid);

            int[] numbers = new int[6];

            if (isFirstValid && isSecondValid && isThirdValid && isThirdValid && isFourthValid && isFifthValid && isSixthValid)
            {
                numbers[0] = firstValid;
                numbers[1] = secondValid;
                numbers[2] = thirdValid;
                numbers[3] = fourthValid;
                numbers[4] = fifthValid;
                numbers[5] = sixthValid;

                int result = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if(numbers[i] % 2 == 0)
                    {
                        
                        result += numbers[i];
                    }
                }
                Console.WriteLine(result);
            }

        }
    }
}
