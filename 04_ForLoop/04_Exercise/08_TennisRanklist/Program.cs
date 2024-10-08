int numberTournaments = int.Parse(Console.ReadLine());
int startingRang = int.Parse(Console.ReadLine());

double points = 0;
double winner = 0;
for (int i = 0; i < numberTournaments; i++)
{
    string nameOfTournament = Console.ReadLine();

    if (nameOfTournament == "W")
    {
        points += 2000;
        winner++;
    }
    else if (nameOfTournament == "F")
    {
        points += 1200;
    }
    else if (nameOfTournament == "SF")
    {
        points += 720;
    }
}
Console.WriteLine($"Final points: {points + startingRang}");
Console.WriteLine($"Average points: {Math.Floor(points / numberTournaments)}");
Console.WriteLine($"{(winner != 0 ? (winner / numberTournaments * 100) : 0):f2}%");
