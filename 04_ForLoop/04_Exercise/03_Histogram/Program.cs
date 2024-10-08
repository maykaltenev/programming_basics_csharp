int n = int.Parse(Console.ReadLine());

int p1 = 0;
int p2 = 0;
int p3 = 0;
int p4 = 0;
int p5 = 0;

for (int i = 0; i < n; i++)
{
    int current = int.Parse(Console.ReadLine());

    if (current < 200)
    {
        p1++;
    }
    else if (current >= 200 && current <= 399)
    {
        p2++;
    }
    else if (current >= 400 && current <= 599)
    {
        p3++;
    }
    else if (current >= 600 && current <= 799)
    {
        p4++;
    }
    else if (current >= 800)
    {
        p5++;
    }
}

Console.WriteLine($"{(p1 != 0 ? (p1 / (double)n * 100) : 0):f2}%");
Console.WriteLine($"{(p2 != 0 ? (p2 / (double)n * 100) : 0):f2}%");
Console.WriteLine($"{(p3 != 0 ? (p3 / (double)n * 100) : 0):f2}%");
Console.WriteLine($"{(p4 != 0 ? (p4 / (double)n * 100) : 0):f2}%");
Console.WriteLine($"{(p5 != 0 ? (p5 / (double)n * 100) : 0):f2}%");
