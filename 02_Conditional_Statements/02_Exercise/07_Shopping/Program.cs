double budget = double.Parse(Console.ReadLine());
double videoCards = double.Parse(Console.ReadLine());
double processors = double.Parse(Console.ReadLine());
double memory = double.Parse(Console.ReadLine());

double costVideoCard = 250;
double totalVideoCard = videoCards * 250;

double priceProcessors = totalVideoCard * 0.35;
double priceMemory = totalVideoCard * 0.10;

double totalProcessors = processors * priceProcessors;
double totalMemory = memory * priceMemory;

double totalSum = totalMemory + totalVideoCard + totalProcessors;

if (videoCards > processors)
{
    totalSum *= 0.85;
}

double result = Math.Abs(budget - totalSum);
if (budget >= totalSum)
{
    Console.WriteLine($"You have {result:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {result:f2} leva more!");
}
