using System;

namespace Igor.Class03.Homework.Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] studentsG1 =
            {
                "Zdravko",
                "Petko",
                "Stanko",
                "Branko",
                "Trajko"
            };

            string[] studentsG2 =
            {
                "Ana",
                "Igor",
                "Aleksandar",
                "Eva",
                "Angel"
            };

            Console.WriteLine("Please enter a number to display which group 1 or 2 : ");
            string userChoice = Console.ReadLine();

            if (userChoice == "1" || userChoice == "2")
            {
                if(userChoice == "1")
                {
                    foreach(string student in studentsG1)
                    {
                        Console.WriteLine(student);
                    }
                }
                else if(userChoice == "2")
                {
                    foreach(string student in studentsG2)
                    {
                        Console.WriteLine(student);
                    }
                }
            }
            else
            {
                Console.WriteLine("Group not found.");
            }
            Console.ReadLine();
        }
    }
}
