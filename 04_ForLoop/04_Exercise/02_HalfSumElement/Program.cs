int n = int.Parse(Console.ReadLine());

int maxValue = Int32.MinValue;
int sumNumbers = 0;
for (int i = 0; i < n; i++)
{
    int current = int.Parse(Console.ReadLine());
    sumNumbers += current;
    if (current > maxValue)
    {
        maxValue = current;
    }
}
if (sumNumbers - maxValue == maxValue)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {maxValue}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(sumNumbers - (maxValue * 2))}");
}
