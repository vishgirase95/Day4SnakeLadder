using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {

        public void option()
        {
            Random opt = new Random();
            int ChoseOption = opt.Next(1, 4);
            int dice = opt.Next(1, 7);
            int player1 = 0;


            

            if (ChoseOption == 1)
            {
                player1 = 0;
                Console.WriteLine("no play");
                Console.WriteLine(dice + "dice value");

            }
            else if (ChoseOption == 2)
            {
                player1 = player1 + dice;
                Console.WriteLine("Ladder");
                Console.WriteLine(dice + "dice value");


            }
            else
            {
                player1 = player1 -dice;
                Console.WriteLine("Snake");
                Console.WriteLine(dice+"dice value");



            }


            player(player1);
        }

        public void player(int player1)
        {
            int position = player1+1;

            
        }


    }
}
