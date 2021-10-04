using System;

namespace Snakeladder
{
    class Program
    {
        static void Main(string[] args)
        {
            UC2_Number.RandomNumber();
            UC1_SinglePlayer.SinglePosition();
            UC3_Noplay_Ladder.PositionCheck();
            UC4_WinningPosition.WinnerPosition();
            UC5_ExactWinningPosition.ExactWinningPosition();
            UC6_No_Of_Dice.TimesPlayed();
            UC7_TwoPlayers.TwoPlayer();
        }
    }
}
