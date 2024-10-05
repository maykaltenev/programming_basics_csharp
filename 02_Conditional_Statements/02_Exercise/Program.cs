int startPoints = Console.ReadLine();
int bonus = 0;
∂
if (startPoints <= 100)
{
    bonus += 5;
}
else if (startPoints > 100)
{
    bonus += startPoints * 0.20;
}
else if (startPoints > 1000)
{
    bonus += startPoints * 0.10;
}

if (startPoints % 2 == 0)
{
    bonus += 1;
}
if (startPoints % 10 == 5)
{
    bonus += 2;
}

Console.WriteLine(bonus);
Console.WriteLine($"{startPoints + bonus}");
