double budget = double.Parse(Console.ReadLine());
double people = double.Parse(Console.ReadLine());
double priceClothOnePerson = double.Parse(Console.ReadLine());

double decor = budget * 0.10;
double clothPrice = priceClothOnePerson * people;
double discount = 0.0;
if (people > 150)
{
    discount = clothPrice * 0.10;
    clothPrice -= discount;
}

double totalCost = clothPrice + decor;
double result = Math.Abs(budget - totalCost);
if (budget >= totalCost)
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {result:f2} leva left.");
}
else
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {result:f2} leva more.");
}
