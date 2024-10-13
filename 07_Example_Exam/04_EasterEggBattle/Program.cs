using System;

namespace EasterEggBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerOne = int.Parse(Console.ReadLine());
            int playerTwo = int.Parse(Console.ReadLine());

            bool lostEggs = false;
            string action = "";

            while (action != "End")
            {
                if (action == "one")
                {
                    playerTwo--;
                    if (playerTwo <= 0)
                    {
                        Console.WriteLine(
                            $"Player two is out of eggs. Player one has {playerOne} eggs left."
                        );
                        lostEggs = true;
                        break;
                    }
                }
                else if (action == "two")
                {
                    playerOne--;
                    if (playerOne <= 0)
                    {
                        Console.WriteLine(
                            $"Player one is out of eggs. Player two has {playerTwo} eggs left."
                        );
                        lostEggs = true;
                        break;
                    }
                }
                action = Console.ReadLine();
            }

            if (!lostEggs)
            {
                Console.WriteLine($"Player one has {playerOne} eggs left.");
                Console.WriteLine($"Player two has {playerTwo} eggs left.");
            }
        }
    }
}
