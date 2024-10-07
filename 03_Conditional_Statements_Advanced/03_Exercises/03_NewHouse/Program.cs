string typeFlower = Console.ReadLine();
int countFlowers = int.Parse(Console.ReadLine());
double budget = double.Parse(Console.ReadLine());

double price = 0.0;
if (typeFlower == "Roses")
{
    price = countFlowers * 5;
    if (countFlowers > 80)
    {
        price *= 0.9;
    }
}
else if (typeFlower == "Tulips")
{
    price = countFlowers * 2.80;
    if (countFlowers > 80)
    {
        price *= 0.85;
    }
}
else if (typeFlower == "Narcissus")
{
    price = countFlowers * 3;
    if (countFlowers < 120)
    {
        price *= 1.15;
    }
}
else if (typeFlower == "Gladiolus")
{
    price = countFlowers * 2.5;
    if (countFlowers < 80)
    {
        price *= 1.20;
    }
}
else if (typeFlower == "Dahlias")
{
    price = countFlowers * 3.80;
    if (countFlowers > 90)
    {
        price *= 0.85;
    }
}

if (budget >= price)
{
    Console.WriteLine(
        $"Hey, you have a great garden with {countFlowers} {typeFlower} and {(budget - price):f2} leva left."
    );
}
else
{
    Console.WriteLine($"Not enough money, you need {(price - budget):f2} leva more.");
}
