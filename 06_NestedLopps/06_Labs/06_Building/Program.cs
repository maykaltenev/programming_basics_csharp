int floor = int.Parse(Console.ReadLine());
int room = int.Parse(Console.ReadLine());

for (int i = floor; i > 0; i--)
{
    char letter;
    if (i == floor)
    {
        letter = 'L';
    }
    else if (i % 2 == 0)
    {
        letter = 'O';
    }
    else
    {
        letter = 'A';
    }
    for (int y = 0; y < room; y++)
    {
        if (y > 0)
        {
            Console.Write(' ');
        }
        Console.Write($"{letter}{i}{y}");
    }
    Console.WriteLine();
}
