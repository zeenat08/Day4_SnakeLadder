using System;
using System.Collections.Generic;
using System.Text;

namespace Snakeladder
{
    class UC3_Noplay_Ladder
    {
        //constants

        public static void PositionCheck()
        {
            int no_Play = 0;
            int ladder = 1;
            int snake = 2;
            //variables
            int playerPosition = 0;
            Random ran = new Random();
            int playerCheck = ran.Next(0, 3);
            int diceValue = ran.Next(0, 7);

            switch (playerCheck)
            {
                case 0:
                    Console.WriteLine("No play, pass the dice");
                    break;
                case 1:
                    playerPosition += diceValue;
                    Console.WriteLine("You got ladder " + "and your position is now: " + playerPosition);
                    break;
                case 2:
                    if (playerPosition <= 0)
                    {
                        Console.WriteLine("You are still in Zero(0) position");
                    }
                    break;
            }
        }
    }
}
