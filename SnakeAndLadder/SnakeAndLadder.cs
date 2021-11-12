using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    public class SnakeAndLadder
    {
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING = 100, START = 0;
        public int playerPosition = 0, count = 0;
        Random random = new Random();
        public int DieRoll()
        {
            int roll = random.Next(1, 7);
            return roll;
        }
        public void PlayerCheck()
        {
            while (playerPosition < WINNING)
            {
                int dieRoll = this.DieRoll();
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        this.playerPosition += dieRoll;
                        if (this.playerPosition > WINNING)
                        {
                            this.playerPosition -= dieRoll;
                        }
                        Console.WriteLine("Got Ladder");
                        break;
                    case SNAKE:
                        this.playerPosition -= dieRoll;
                        if (this.playerPosition < START)
                        {
                            this.playerPosition = START;
                        }
                        Console.WriteLine("Got Snake");
                        break;
                }
                count++;
                Console.WriteLine("The Player Position is :" + this.playerPosition + " " + "with a roll of " + dieRoll);
            }
            Console.WriteLine("The number of times dice was played to win the game is : " + count);
            Console.WriteLine("The Player wins the game");
        }
    }
}