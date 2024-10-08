int count = int.Parse(Console.ReadLine());

int maxNumber = Int32.MinValue;
int minValue = Int32.MaxValue;
for (int i = 0; i < count; i++)
{
    int n = int.Parse(Console.ReadLine());
    if (n > maxNumber)
    {
        maxNumber = n;
    }
    if (n < minValue)
    {
        minValue = n;
    }
}
Console.WriteLine($"Max number: {maxNumber}");
Console.WriteLine($"Min number: {minValue}");
