string input = Console.ReadLine();
double total = 0;
while (input != "NoMoreMoney")
{
    double operation = double.Parse(input);
    if (operation < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    Console.WriteLine($"Increase: {operation:f2}");
    total += operation;
    input = Console.ReadLine();
}

Console.WriteLine($"Total: {total:f2}");
