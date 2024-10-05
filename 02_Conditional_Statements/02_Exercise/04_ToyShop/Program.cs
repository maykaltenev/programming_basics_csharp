double puzzle = 2.60;
double doll = 3;
double bear = 4.10;
double minion = 8.20;
double truck = 2;

double priceTrip = double.Parse(Console.ReadLine());
double numberPuzzles = double.Parse(Console.ReadLine());
double numberDolls = double.Parse(Console.ReadLine());
double numberBears = double.Parse(Console.ReadLine());
double numberMinions = double.Parse(Console.ReadLine());
double numberTrucks = double.Parse(Console.ReadLine());

double totalNumberToys = numberPuzzles + numberDolls + numberBears + numberMinions + numberTrucks;

double discount = 0.0;

double costPuzzle = numberPuzzles * puzzle;
double costDoll = numberDolls * doll;
double costBear = numberBears * bear;
double costMinion = numberMinions * minion;
double costTruck = numberTrucks * truck;

double totalWin = costPuzzle + costDoll + costBear + costMinion + costTruck;

if (totalNumberToys >= 50)
{
    discount = totalWin * 0.25;
    totalWin -= discount;
}
double afterRent = totalWin * 0.90;
double result = Math.Abs(afterRent - priceTrip);
if (afterRent >= priceTrip)
{
    Console.WriteLine($"Yes! {result:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {result:f2} lv needed.");
}
