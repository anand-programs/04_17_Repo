using System;

namespace SplittingString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter names of players separated by comma : ");
            string players = Console.ReadLine();

            Console.WriteLine(players);

            string[] playerName = players.Split(',');

            foreach (string str in playerName)
            {
                Console.WriteLine(str);
            }
        }
    }
}
