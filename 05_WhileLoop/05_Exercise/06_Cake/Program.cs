int width = int.Parse(Console.ReadLine());
int hight = int.Parse(Console.ReadLine());

int numberPieces = width * hight;
bool stop = false;

while (!stop)
{
    string action = Console.ReadLine();

    if (action == "STOP")
    {
        stop = true;
        break;
    }
    else
    {
        int pieceTaken = int.Parse(action);
        numberPieces -= pieceTaken;
        if (numberPieces < 0)
        {
            stop = true;
            break;
        }
    }
}
if (stop && numberPieces > 0)
{
    Console.WriteLine($"{numberPieces} pieces are left.");
}
else
{
    Console.WriteLine($"No more cake left! You need {Math.Abs(numberPieces)} pieces more.");
}
