int minNumber = int.MaxValue;
string input = Console.ReadLine();
while (input != "Stop")
{
    int number = int.Parse(input);
    if (minNumber > number)
    {
        minNumber = number;
    }
    input = Console.ReadLine();
}

Console.WriteLine(minNumber);
