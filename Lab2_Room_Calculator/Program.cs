using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;

namespace Lab2_Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and Welcome to Room Calculator!\n");
            bool userContinue = true;
            while (userContinue)
            {

                Console.Write("Please enter the length of the room: ");
                double length = double.Parse(Console.ReadLine());

                Console.Write("Please enter the width of the room: ");
                double width = double.Parse(Console.ReadLine());

                Console.Write("Please enter the height of the room: ");
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine($"The Area is: {CalculateArea(length, width)} units squared");
                Console.WriteLine($"The Perimeter is: {CalculatePerimeter(length, width)} units");
                Console.WriteLine($"The Volume is: {CalculateVolume(length, width, height)} units cubed\n");

                string userAnswer = GetUserInput("Would you like to calculate another room? y/n", "y", "n");
                if(userAnswer != "y")
                {
                    userContinue = false;
                }
            }
            Console.WriteLine("Thanks for using Room Calculator!");
        }

        public static string GetUserInput(string message, string option1_true, string option2_false)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine().ToLower();
            if(userInput == option1_true)
            {
                return option1_true;
            }
            else if (userInput == option2_false)
            {
                return option2_false;
            }
            else
            {
                return GetUserInput(message, option1_true, option2_false);
            }
        }
        public static double CalculateArea(double length, double width)
        {   
           return length * width;
        }

        public static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width); 
        }
        public static double CalculateVolume(double length, double width , double height)
        {
            return length * width * height;
        }
    }
}
