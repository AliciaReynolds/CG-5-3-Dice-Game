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
            /*
            int UserRolls = 0;
            int[] User = UserGame(out UserRolls);
            int sum = 0;
            for (int i = 0; i < User.Length; i++)
            {
                sum += User[i];
            }
            */
            if (sum >= 20)
            {
                Console.WriteLine("You win!!");
            }
            else if (sum < 20)
            {
                Console.WriteLine("Sorry.  You don't win.  Now it's the Computer's turn.");

            }


            Console.ReadLine();

        }

        /* private static int[] UserGame(out int UserRolls)
         {
             UserRolls = 0;

             int[] User = new int[20];
             Random rand = new Random();

             for (int i = 0; i <= 12; i++)
             {
                 int randuser = rand.Next(1, 6);
                 UserRolls = randuser;
                 User[i] = UserRolls;
                 UserRolls = i;
             }
             int UserRolls = 0;
             int[] User = UserGame(out UserRolls);
             int sum = 0;
             for (int i = 0; i < User.Length; i++)
             {
                 sum += User[i];
             }

         }
         */

        private static int UserGame()
        {
            int[] User = 
        }


    }
}
