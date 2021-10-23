using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void myfun()
        {

        }
       
         


        static void Main(string[] args)
        {
           
            
            int winner =100;
            int count = 0;
            int ladder = 2;
            bool check = false;
               int player=0;
            int[] Player_position = new int[] { 0, 0 };
           
           
            while (Player_position[player] < 100 && winner == 100)

                {
                  
                    Random opt = new Random();
                    int ChoseOption = opt.Next(1,3);
                    int dice = opt.Next(1, 7);
                
                
                if (ChoseOption == ladder)
                      {
                    check = true;
                    Player_position[player] = Player_position[player] + dice;

                        if (Player_position[player] < 100)
                        {
                            Console.WriteLine($"{player+1} is Ladder dice is {dice} and position value is :{ Player_position[player]}");

                        }
                        else if (Player_position[player] == 100)
                        {

                            Console.WriteLine($" {player+1}   its 100");
                            winner = 10;

                        }
                        else
                        {

                        Player_position[player] = Player_position[player] - dice;
                       
                        }

                        count++;
                    }


                    else
                    {
                    Player_position[player] = Player_position[player] - dice;

                        count++;
                        Console.WriteLine($"Snake dice is {dice} and position value is :{ Player_position[player]}");
                        check = false;
                    }


                    if (Player_position[player] < 0)
                    {
                    Player_position[player] = 0;
                    }
                if (check == false)
                {
                    if (player == 0)
                    {
                        player = 1;
                    }
                    else
                    {
                        player = 0;
                    }
                }
                }
                Console.WriteLine($"Player {player+1}  The winner  position is {Player_position[player]}  and the count of dice is {count}");
            }
        }

    }

