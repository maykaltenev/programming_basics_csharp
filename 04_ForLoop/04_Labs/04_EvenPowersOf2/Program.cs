int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    if (i == 1)
    {
        Console.WriteLine(i);
    }
    if (i % 2 == 0)
    {
        Console.WriteLine(Math.Pow(2, i));
    }
}
