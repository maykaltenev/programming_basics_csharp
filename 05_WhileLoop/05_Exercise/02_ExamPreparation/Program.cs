int failedThreshold = int.Parse(Console.ReadLine());

double total = 0.0;
int fail = 0;
int solved = 0;
string lastTask = "";
bool isFailed = true;

while (fail <= failedThreshold)
{
    string taskName = Console.ReadLine();
    if (taskName == "Enough")
    {
        isFailed = false;
        break;
    }
    lastTask = taskName;
    int score = int.Parse(Console.ReadLine());
    if (score <= 4)
    {
        fail++;
        if (fail == failedThreshold)
        {
            break;
        }
    }
    solved++;
    total += score;
}

if (isFailed)
{
    Console.WriteLine($"You need a break, {fail} poor grades.");
}
else
{
    if (solved > 0)
    {
        Console.WriteLine($"Average score: {(total / solved):f2}");
        Console.WriteLine($"Number of problems: {solved}");
        Console.WriteLine($"Last problem: {lastTask}");
    }
}
