using System;

namespace MethodsExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, what is your name?");

            string name = Console.ReadLine();

            Console.WriteLine($"Ok, I have some questions for you {name}");

            Console.WriteLine("You ready?");

            string answer = Console.ReadLine();

            Console.WriteLine("I don't care.What's your favorite color?");

            string color = Console.ReadLine();

            Console.WriteLine($"Really? Based on that outfit I never would have guessed");

            Console.WriteLine("Well anyway, what's your favorite animal? For the sake of this one sided conversation.");

            string animal = Console.ReadLine();

            Console.WriteLine($" Wowwww so ~qUiRkY~. Ok, I'm going to try one more question.");

            Console.WriteLine("And please, PLEASE give me something I can work with here - what's your all time favorite band?");

            string band = Console.ReadLine();

            Console.WriteLine($"Really!? I love {band}! What's your favorite album?!");

            string album = Console.ReadLine();

            Console.WriteLine($"*sighs* Never mind, that's not on their discography....");

            string response = Console.ReadLine();

            Console.WriteLine("...");

            Console.WriteLine("So THAT'S your response?");

            Console.WriteLine($" '{response}' <--- your words ");

            Console.WriteLine(".... I think I'm going to go now.");

            Console.WriteLine("Please don't run this program anymore. Not sure if I can go through this again");
        }
    }
}
