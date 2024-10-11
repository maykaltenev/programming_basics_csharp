string destination = Console.ReadLine();

while (destination != "End")
{
    double requiredBudget = double.Parse(Console.ReadLine());
    double currentSavings = 0;

    while (currentSavings < requiredBudget)
    {
        double savedMoney = double.Parse(Console.ReadLine());
        currentSavings += savedMoney;
    }

    Console.WriteLine($"Going to {destination}!");
    destination = Console.ReadLine();
}
