using System;

namespace EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string currentBaker = "";
            string leader = "";
            int leaderPoints = 0;
            int currentPoints = 0;
            bool leaderChange = false;
            for (int i = 0; i < number; i++)
            {
                string baker = Console.ReadLine();
                currentBaker = baker;

                while (true)
                {
                    string action = Console.ReadLine();
                    if (action == "Stop")
                    {
                        break;
                    }
                    int points = int.Parse(action);
                    if (points <= 0 || points > 10)
                    {
                        action = Console.ReadLine();
                        continue;
                    }
                    currentPoints += points;
                }
                Console.WriteLine($"{currentBaker} has {currentPoints} points.");
                if (currentPoints > leaderPoints)
                {
                    leaderPoints = currentPoints;
                    leader = currentBaker;
                    Console.WriteLine($"{leader} is the new number 1!");
                }
                currentBaker = "";
                currentPoints = 0;
            }
            Console.WriteLine($"{leader} won competition with {leaderPoints} points!");
        }
    }
}
