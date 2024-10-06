string name = Console.ReadLine();
double episodeTime = double.Parse(Console.ReadLine());
double breakTime = double.Parse(Console.ReadLine());

double lunchTime = breakTime * 0.125;

double relaxTime = breakTime * 0.25;

double totalBreakTime = lunchTime + relaxTime;

double resultTime = breakTime - totalBreakTime;

if (resultTime >= episodeTime)
{
    Console.WriteLine(
        $"You have enough time to watch {name} and left with {Math.Ceiling(resultTime - episodeTime)} minutes free time."
    );
}
else
{
    Console.WriteLine(
        $"You don't have enough time to watch {name}, you need {Math.Ceiling(episodeTime - resultTime)} more minutes."
    );
}
