string nameOfArchitect = Console.ReadLine();
int numberOfProjects = int.Parse(Console.ReadLine());
int timePerProject = 3;
int totalTimeNeeded = numberOfProjects * timePerProject;

Console.WriteLine(
    $"The architect {nameOfArchitect} will need {totalTimeNeeded} hours to complete {numberOfProjects} project/s."
);
