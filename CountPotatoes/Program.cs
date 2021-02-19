using System;

namespace CountPotatoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int bags = 0;
            do
            {
                //prompt user to put a number
                Console.WriteLine("How many bags full of potatoes are there? (Please put a number between 1 to 40)");
                try
                {
                    //read user input
                    bags = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a value between 1 and 40");
                }

            }
            while (!(bags >= 1 && bags <= 40));

            //create a potatoes object
            Potatoes potatoes = new Potatoes();

            Console.WriteLine("\nThe difference between the number of red potatoes and russet potatoes:");
            //print the result/difference between russet and red potatoes
            Console.WriteLine($"{potatoes.PotatoDifference(bags)}");
        }
    }
}
