using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        public int player1 = 0;

        public void option()
        {
            Random opt = new Random();
            int ChoseOption = opt.Next(1, 4);
            int dice = opt.Next(1, 7);

            

            if (ChoseOption == 1)
            {
                player1 = 0;
                Console.WriteLine("no play");
            }
            else if (ChoseOption == 2)
            {
                player1 = player1 + dice;
                Console.WriteLine("Ladder");

            }
            else
            {
                player1 = player1 - dice;
                Console.WriteLine("Snake");
                

            }
            

         
        }

        public int player()
        {
            int position = player1;

            return position;
        }


    }
}
