int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int totalMinutes = minutes + 15;

if (totalMinutes >= 60)
{
    hours++;
    totalMinutes -= 60;
}

if (hours > 23)
{
    hours = 0;
}
if (totalMinutes < 10)
{
    Console.Write($"{hours}:0{totalMinutes}");
}
else
{
    Console.Write($"{hours}:{totalMinutes}");
}
