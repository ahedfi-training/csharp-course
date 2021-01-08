using System;

namespace Soutions
{
    public static class Conditionals
    {
        /// <summary>
        /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
        /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
        /// applications where values entered into input boxes need to be validated.)
        /// </summary>
        public static void Exercise1()
        {
            Console.Write("Enter a number between 1 to 10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }

        /// <summary>
        /// Write a program which takes two numbers from the console and displays the maximum of the two.
        /// </summary>
        public static void Exercise2()
        {
            Console.Write("Enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max is " + max);
        }

        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
        public static void Exercise3()
        {
            Console.Write("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }
    }
}
