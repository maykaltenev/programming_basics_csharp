int numberOfPagesCurrentBook = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int totalDays = int.Parse(Console.ReadLine());

int totalTimeReading = numberOfPagesCurrentBook / pagesPerHour;
int timeNeededInHours = totalTimeReading / totalDays;

Console.WriteLine(timeNeededInHours);
