//Guessing Game With 4 Difficulties with varying amount of lives, Soon to be updated to increase range of numbers on users 

using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome To The Guessing Game!");
            Random rand = new Random();
            int rndmNum = rand.Next(1, 99);
            int userGuess = 0;
            int Lives = 0;
            int Tries = 0;
            // Sets Lives Depending On Difficulty User Selects And Ends Script If User Fails
            Console.WriteLine("Pick A Number Corresponding To A Difficulty 1-Easy / 2-Medium / 3-Hard / 4-Infinite");
            int diff = Convert.ToInt32(Console.ReadLine());

            if  (diff < 1 || diff > 4)
            {
                Console.WriteLine("Please Restart And Select A Number In The Range Corresponding To The Difficulty.");
                return;
            }

            if (diff == 1)
            {
                Lives = 10;
                Console.WriteLine("Welcome To The Easy Difficulty You Have 10 Lives.");
                Console.WriteLine("The Magic Number Is Between 1 And 99 What Do You Think It Is :). ");

                while (Lives > 0)
                {
                    Console.Write("Enter What You Think It Is: ");
                    userGuess = int.Parse(Console.ReadLine());
                    Lives--;
                
                    if (userGuess < rndmNum)
                    {
                        Console.WriteLine("The Number Is Greater Than: " + userGuess + " Try Again");
                    }
                    else if (userGuess > rndmNum)
                    {
                        Console.WriteLine("The Number Is Smaller Than: " + userGuess + " Try Again");
                    }
                    else if (userGuess == rndmNum)
                    {
                        Console.WriteLine("Congrats You Won With " + Lives + " Lives Left");
                        return;
                    }
                }
                Console.WriteLine("You Failed Try Again!");
                return;
            }

            if (diff == 2)
            {
                Lives = 6;
                Console.WriteLine("Welcome To The Medium Difficulty You Have 6 Lives.");
                Console.WriteLine("The Magic Number Is Between 1 And 99 What Do You Think It Is :). ");

                while (Lives > 0)
                {
                    Console.Write("Enter What You Think It Is: ");
                    userGuess = int.Parse(Console.ReadLine());
                    Lives--;
                
                    if (userGuess < rndmNum)
                    {
                        Console.WriteLine("The Number Is Greater Than: " + userGuess + " Try Again");
                    }
                    else if (userGuess > rndmNum)
                    {
                        Console.WriteLine("The Number Is Smaller Than: " + userGuess + " Try Again");
                    }
                    else if (userGuess == rndmNum)
                    {
                        Console.WriteLine("Congrats You Won With " + Lives + " Lives Left");
                        return;
                    }
                }
                Console.WriteLine("You Failed Try Again!");
                return;
            }

            if (diff == 3)
            {
                Lives = 3;
                Console.WriteLine("Welcome To The Hard Difficulty You Have 3 Lives.");
                Console.WriteLine("The Magic Number Is Between 1 And 99 What Do You Think It Is :). ");

                while (Lives > 0)
                {
                    Console.Write("Enter What You Think It Is: ");
                    userGuess = int.Parse(Console.ReadLine());
                    Lives--;
                
                    if (userGuess < rndmNum)
                    {
                        Console.WriteLine("The Number Is Greater Than: " + userGuess + " Try Again");
                    }
                    else if (userGuess > rndmNum)
                    {
                        Console.WriteLine("The Number Is Smaller Than: " + userGuess + " Try Again");
                    }
                    else if (userGuess == rndmNum)
                    {
                        Console.WriteLine("Congrats You Won With " + Lives + " Lives Left");
                        return;
                    }
                }
                Console.WriteLine("You Failed Try Again!");
                return;
            }

            if (diff == 4)
            {
                Tries = 0;
                Console.WriteLine("Welcome To The Infinite Difficulty You Have Unlimited Lives.");
                Console.WriteLine("The Magic Number Is Between 1 And 99 What Do You Think It Is :). ");

                while (userGuess != rndmNum)
                {
                    Console.Write("Enter What You Think It Is: ");
                    userGuess = int.Parse(Console.ReadLine());
                    Tries++;
                
                    if (userGuess < rndmNum)
                    {
                        Console.WriteLine("The Number Is Greater Than: " + userGuess + " Try Again");
                    }
                    else if (userGuess > rndmNum)
                    {
                        Console.WriteLine("The Number Is Smaller Than: " + userGuess +" Try Again");
                    }
                }
                Console.WriteLine("Congrats It Took You: " + Tries + " guesses. Play Again On A Different Difficulty :)");
            }
        }
    }
}

