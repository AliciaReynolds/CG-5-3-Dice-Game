using System;

namespace CG_5_3_Dice_Game
{
    class Program
    {


        static void Main(string[] args)
        {
            //This coding sets up the instructions for the game
            Console.WriteLine("Let's play a game.");
            Console.WriteLine("The object of the game is to roll the two dice");
            Console.WriteLine("until you get 20 or more.");
            Console.WriteLine("And to do it before the computer does.");
            Console.WriteLine("May the odds ever be in your favor.");

            //This code is supposed to start being the counter
            int userRolls = 0;
            int computerRolls = 0;


           //This code is supposed to help set up the counter so that we can roll to get to 20
                while (userRolls > 20 || computerRolls > 20)
                {
                    userRolls = userRolls + RollDice();
                    Console.WriteLine(userRolls);
                    computerRolls = computerRolls + RollDice();
                    Console.WriteLine(computerRolls);
                }
            

                //This code hopefully writes out the totals that don't seem to be printing anywhere
            Console.WriteLine(userRolls);
            Console.WriteLine(computerRolls);

            //This code is supposed to help figure out the winner, by saying if one is before the othe
            //they win otherwise the computer wins.
            if (userRolls > computerRolls)
            {
                Console.WriteLine("The player wins!");
            }

            else //(computerRolls > userRolls)
                    Console.WriteLine("The computer wins!");
      


            /*have it spit out which counter hits 20 first.  Right now it's not going to say
            that, it's just going to shoot out "you win" when someone hits it but not exactly
            who*/

                
            Console.ReadLine();

            
        }
        /// <summary>
        /// This is method is to simmulate the rolling of two dice
        /// </summary>
        /// <returns>shoudl print out the total of the dice</returns>
        private static int RollDice()
        {
            //This coding creates one dice roll
            Random randomUser = new Random();
            int User = randomUser.Next(1, 6);
           // Console.WriteLine("Player, you are up first.");
           // Console.WriteLine($"Your first roll is {User}.");

            //This coding creates the other dice roll
            Random randomUser2 = new Random();
            int User2 = randomUser2.Next(1, 6);
            //Console.WriteLine($"Your second roll is {User2}");

            //This coding creates the total of the two rolls
            int total = User + User2;
            //Console.WriteLine($"Which gives you a total of {total}");

            //This returns the total information to be used outside the method
            return total;
        }


        //private static int CompGame()
        //{
        //    Random randomComp = new Random();
        //    int Comp = randomComp.Next(1, 6);
        //    Console.WriteLine("Computer, you are next");
        //    Console.WriteLine($"Your first roll is {Comp}.");

        //    Random randomCompr2 = new Random();
        //    int Comp2 = randomComp2.Next(1, 6);
        //    Console.WriteLine($"Your second roll is {Comp2}");

        //    int total = Comp + Comp2;
        //    Console.WriteLine($"Which gives you a total of {total}");


        //}

    }
}
