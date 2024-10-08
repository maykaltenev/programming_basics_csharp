string nameOfParticipant = Console.ReadLine();
double startingPoints = double.Parse(Console.ReadLine());
int numberOfPeopleToNominate = int.Parse(Console.ReadLine());

double sumPoints = 0;
double currentResult = 0;
for (int i = 0; i < numberOfPeopleToNominate; i++)
{
    string personToNominate = Console.ReadLine();
    double pointsGiven = double.Parse(Console.ReadLine());

    sumPoints += personToNominate.Length * pointsGiven / 2;
    currentResult = sumPoints + startingPoints;
    if (currentResult >= 1250.5)
    {
        Console.WriteLine(
            $"Congratulations, {nameOfParticipant} got a nominee for leading role with {currentResult:f1}!"
        );
        return;
    }
}
Console.WriteLine($"Sorry, {nameOfParticipant} you need {(1250.5 - currentResult):f1} more!");
