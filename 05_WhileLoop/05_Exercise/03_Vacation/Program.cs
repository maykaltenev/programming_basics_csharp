double moneyForTrip = double.Parse(Console.ReadLine());
double currentMoney = double.Parse(Console.ReadLine());

int spendingDays = 0;
int totalDays = 0;
bool isAbleToSave = true;

while (currentMoney < moneyForTrip)
{
    string action = Console.ReadLine();
    double amount = double.Parse(Console.ReadLine());
    totalDays++;
    if (action == "spend")
    {
        spendingDays++;

        if (spendingDays == 5)
        {
            isAbleToSave = false;
            break;
        }

        currentMoney = Math.Max(currentMoney - amount, 0.0);
    }
    else if (action == "save")
    {
        currentMoney += amount;
        spendingDays = 0;
    }
}
if (isAbleToSave)
{
    Console.WriteLine($"You saved the money for {totalDays} days.");
}
else
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine($"{totalDays}");
}
