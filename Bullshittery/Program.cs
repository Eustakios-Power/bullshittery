using System;

namespace Bullshittery
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 100);
            Console.WriteLine("Guess the number between 0 and 100:");
            int input;
            bool correct = false;
            int count = 0;
            while (correct == false)
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                    count++;
                    if(input == num)
                    {
                        Console.WriteLine($"Yep, {num} is the correct number");
                        correct = true;
                    }
                    else if(input > num)
                    {
                        Console.WriteLine("The number is smaller");
                    }
                    else
                    {
                        Console.WriteLine("The number is bigger");
                    }
                }
                catch(Exception ex)
                {
                    correct = false;
                    Console.WriteLine("Introduce a correct number you dumb");
                }
            }
            Console.WriteLine("Downloading the underage midget porn");
        }
    }
}
