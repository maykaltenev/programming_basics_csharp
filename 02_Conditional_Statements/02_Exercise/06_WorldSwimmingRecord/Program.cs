double recordInSeconds = double.Parse(Console.ReadLine());
double lengthInMeters = double.Parse(Console.ReadLine());
double timeOneMeter = double.Parse(Console.ReadLine());

double distanceTime = lengthInMeters * timeOneMeter;

double additionalTime = Math.Floor(lengthInMeters / 15) * 12.5;

double totalTime = distanceTime + additionalTime;
double result = Math.Abs(totalTime - recordInSeconds);

if (totalTime < recordInSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {result:f2} seconds slower.");
}
