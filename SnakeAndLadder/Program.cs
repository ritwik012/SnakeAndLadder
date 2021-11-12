using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO SNAKE AND LADDER SIMULATOR");
            SnakeAndLadder playerOne = new SnakeAndLadder();
            playerOne.DieRoll();
        }
    }
}