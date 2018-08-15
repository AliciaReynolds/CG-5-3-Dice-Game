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

            if (UserGame() => 20)
            {
                Console.WriteLine("You win!");
            }
            
            else if (UserGame() < 20)
            {

            }

            
        }

        private static int UserGame()
        {
            Random randomUser = new Random();
            int User = randomUser.Next(1, 6);
            Console.WriteLine("Player, you are up first.");
            Console.WriteLine($"Your first roll is {User}.");

            Random randomUser2 = new Random();
            int User2 = randomUser2.Next(1, 6);
            Console.WriteLine($"Your second roll is {User2}");

            int total = User + User2;
            Console.WriteLine($"Which gives you a total of {total}");
            

        }


        private static int CompGame()
        {
            Random randomComp = new Random();
            int Comp = randomComp.Next(1, 6);
            Console.WriteLine("Computer, you are next");
            Console.WriteLine($"Your first roll is {Comp}.");

            Random randomCompr2 = new Random();
            int Comp2 = randomComp2.Next(1, 6);
            Console.WriteLine($"Your second roll is {Comp2}");

            int total = Comp + Comp2;
            Console.WriteLine($"Which gives you a total of {total}");


        }

    }
}
