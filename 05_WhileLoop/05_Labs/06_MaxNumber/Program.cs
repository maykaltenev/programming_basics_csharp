int maxNumber = int.MinValue;
string input = Console.ReadLine();
while (input != "Stop")
{
    int number = int.Parse(input);
    if (maxNumber < number)
    {
        maxNumber = number;
    }
    input = Console.ReadLine();
}

Console.WriteLine(maxNumber);
