using System;

namespace TwoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] teams =
            {
                new string[] {"player1", "player2", "player3" },
                new string[] {"player4", "player5" },
                new string[] {"player6", "player7", "player8"},
                new string[] {"player9"}
            };

            foreach (string[] team in teams)
            {
                foreach (string playerName in team)
                {
                    Console.Write(playerName + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
