using System;
using System.Collections.Generic;
using System.Text;

namespace Snakeladder
{
    class UC5_ExactWinningPosition
    {

        public static int PlayerPosition = 0;
        static int diceValue;
        
        public static void ExactWinningPosition()
        {
            int No_Play = 0;
            int ladder = 1;
            int snake = 2;
            int exactwinningposition = 100;
            Console.WriteLine("The start position of player is : " + PlayerPosition);
            Console.WriteLine();
            Random ranval = new Random();
            while (PlayerPosition < 100)
            {
                while (PlayerPosition != 100)
                {
                    int diceroll = ranval.Next(1, 7);
                    int check_play = ranval.Next(3);
                    {
                        switch (check_play)
                        { 
                        case 1:
                            PlayerPosition += diceroll;
                            if (PlayerPosition > 100)
                            {
                                PlayerPosition = 100;
                                PlayerPosition -= diceroll;
                            }
                            break;
                        case 2:
                            PlayerPosition -= diceroll;
                            if (PlayerPosition < 0)
                            {
                                PlayerPosition = 0;
                            }
                            break;
                        }
                    }
                    Console.WriteLine("New position is= " + PlayerPosition);
                }
                Console.WriteLine("Player at position " + PlayerPosition + " and also winner");

            }
        }
    } 
} 

