int firstRow = int.Parse(Console.ReadLine());
int secondRow = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());
int counter = 0;
bool isFound = false;
for (int i = firstRow; i <= secondRow; i++)
{
    for (int y = firstRow; y <= secondRow; y++)
    {
        counter++;
        if (i + y == magicNumber)
        {
            Console.WriteLine($"Combination N:{counter} ({i} + {y} = {magicNumber})");
            isFound = true;
            break;
        }
    }
    if (isFound)
    {
        break;
    }
}
if (!isFound)
{
    Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
}
