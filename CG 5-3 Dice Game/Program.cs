using System;

namespace CG_5_3_Dice_Game
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a game.");
            Console.WriteLine("The object of the game is to roll the two dice");
            Console.WriteLine("until you get 20 or more.");
            Console.WriteLine("And to do it before the computer does.");
            Console.WriteLine("May the odds ever be in your favor.");

        }

        private static int UserGame()
        {
            Random randomUser = new Random();
            int User = randomUser.Next(1, 6);
            Random randomUser2 = new Random();
            int User2 = randomUser2.Next(1, 6);


        }

    }
}
