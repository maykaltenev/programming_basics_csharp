int count = int.Parse(Console.ReadLine());

int odd = 0;
int even = 0;
for (int i = 0; i < count; i++)
{
    int current = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        even += current;
    }
    else
    {
        odd += current;
    }
}

if (odd == even)
{
    Console.WriteLine($"Yes");
    Console.WriteLine($"Sum = {odd}");
}
else
{
    Console.WriteLine($"No");
    Console.WriteLine($"Diff = {Math.Abs(odd - even)}");
}
