int goalLimit = 10000;
int totalSteps = 0;
bool shouldContinue = true;
bool goalReached = false;
while (shouldContinue && !goalReached)
{
    string input = Console.ReadLine();
    int currentSteps = 0;
    if (input == "Going home")
    {
        currentSteps = int.Parse(Console.ReadLine());
        shouldContinue = false;
    }
    else
    {
        currentSteps = int.Parse(input);
    }

    totalSteps += currentSteps;
    if (totalSteps >= goalLimit)
    {
        goalReached = true;
    }
}

if (goalReached)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{totalSteps - goalLimit} steps over the goal!");
}
else
{
    Console.WriteLine($"{goalLimit - totalSteps} more steps to reach goal.");
}
