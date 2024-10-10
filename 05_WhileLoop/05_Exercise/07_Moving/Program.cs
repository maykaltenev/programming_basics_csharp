int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int area = width * length * height;
bool spaceFull = false;

while (!spaceFull)
{
    string command = Console.ReadLine();

    if (command == "Done")
    {
        spaceFull = true;
        break;
    }
    else
    {
        int boxes = int.Parse(command);
        area -= boxes;
        if (area < 0)
        {
            spaceFull = true;
            break;
        }
    }
}
if (spaceFull && area < 0)
{
    Console.WriteLine($"No more free space! You need {Math.Abs(area)} Cubic meters more.");
}
else
{
    Console.WriteLine($"{area} Cubic meters left.");
}
