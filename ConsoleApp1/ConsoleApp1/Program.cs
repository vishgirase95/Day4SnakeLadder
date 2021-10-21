using System;

namespace ConsoleApp1
{
    class Program
    {
       






        static void Main(string[] args)
        {
            Class1 play = new Class1();
            play.option();
            Class1 playerr = new Class1();
            double position=playerr.player();
                        
            Console.WriteLine("player position : "+ position );
        }
    }
}
