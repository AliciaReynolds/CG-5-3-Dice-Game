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


        private static int User()
        {
            Random randomUser = new Random();
            int user = randomUser.Next(1, 6);
            Random randomUser2 = new Random();
            int user2 = randomUser2.Next(1, 6);

            return user + user2;

        }


        private static int Comp()
        {
            Random randomComp = new Random();
            int comp = randomComp.Next(1, 6);
            Random randomComp2 = new Random();
            int comp2 = randomComp2.Next(1, 6);

            return comp + comp2;
        }

    }
}
