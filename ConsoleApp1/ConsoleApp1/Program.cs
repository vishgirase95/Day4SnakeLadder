using System;

namespace ConsoleApp1
{
    class Program
    {
       






        static void Main(string[] args)
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
                player1 = player1 - dice;
                Console.WriteLine("Snake");
                Console.WriteLine(dice + "dice value");
            }


            Console.WriteLine("Position :  " + player1);

        }
    }
}
