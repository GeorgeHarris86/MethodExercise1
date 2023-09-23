using System;


namespace MethodExerCise;


    internal class Program
    {
   
        private static void Main(string[] args)   
        {

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string Color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string Animal = Console.ReadLine();

            Console.WriteLine("What is your favorite song?");
            string Song = Console.ReadLine();


            Console.WriteLine($"There was guy called (userName), he loved the color (Color) he loved it so much he had to have it on all the things he owned.");
            Console.WriteLine($"(userName) loved the color (Color) so much he had his pet (Animal) painted to match his favorite color.");
            Console.WriteLine($"(userName) had a song made I'm (Song) it was a smash hit even his pet (Animal) danced to it");
        }
    }
