using System;
using System.IO;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your colour:");
            string userSign = Console.ReadLine();

            Console.WriteLine(GetColour(userSign));

        }

        public static string[] ReadColour()
        {
            string filePath = @$"C:\Users\opilane\samples\personality.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }

        public static string GetColour(string userInput)
        {
            string[] colour = ReadColour();
            string todayColour = "";

            foreach (string element in colour)
            {
                if (element.Contains(userInput))
                {
                    todayColour = element;
                }
            }

            return todayColour;
        }

    }
}
