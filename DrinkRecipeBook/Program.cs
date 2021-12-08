using System;

namespace DrinkRecipeBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our app. You will find great recipes for drinks in it.");
            Console.WriteLine("Please let me know what you want to do:");
            Console.WriteLine("1. Add Recipe");
            Console.WriteLine("2. Edit Recipe");
            Console.WriteLine("3. Find Recipe");
            Console.WriteLine("4. Delete Recipe");

            string choice = Console.ReadLine();

            Console.WriteLine($"You have chosen option number: {choice}");
        }
    }
}
