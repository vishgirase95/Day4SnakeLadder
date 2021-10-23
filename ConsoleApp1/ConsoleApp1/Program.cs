using System;

namespace ConsoleApp1
{
    class Program
    {
       


        static void Main(string[] args)
        {
           
            int position = 0;
            int winner =100;
            int count = 0;

            while (position < 100 && winner==100 )
             
            {
                int noplay= 1;
                int ladder = 2;
              
                Random opt = new Random();
                int ChoseOption = opt.Next(1, 4);
                int dice = opt.Next(1, 7);

                if (ChoseOption == noplay)
                {
                    
                    Console.WriteLine($"No Play dice is {dice} and position value is :{position}");


                 

                }
                else if (ChoseOption == ladder)
                {
                   
                    position = position + dice;

                    if (position < 100)
                    {
                        Console.WriteLine($"Ladder dice is {dice} and position value is :{position}");
                       
                    }
                    else if (position == 100)
                    {

                        Console.WriteLine("its 100");
                        winner = 10;
               
                    }
                    else
                    {
                       
                        position = position - dice;
                    }

                    count++;
                }
                else
                {
                    position = position - dice;

                    count++;
                    Console.WriteLine($"Snake dice is {dice} and position value is :{position}");
                }
                if (position < 0)
                {
                    position = 0;
                }
            }
            Console.WriteLine($"The winner  position is {position}  and the count of dice is {count}");
        }

    }
}
