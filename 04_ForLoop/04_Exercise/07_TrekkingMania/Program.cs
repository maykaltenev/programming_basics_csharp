int numberOfGroups = int.Parse(Console.ReadLine());

int group1 = 0;
int group2 = 0;
int group3 = 0;
int group4 = 0;
int group5 = 0;
int totalClimbers = 0;
for (int i = 0; i < numberOfGroups; i++)
{
    int group = int.Parse(Console.ReadLine());

    if (group <= 5)
    {
        group1 += group;
    }
    else if (group >= 6 && group <= 12)
    {
        group2 += group;
    }
    else if (group >= 13 && group <= 25)
    {
        group3 += group;
    }
    else if (group >= 26 && group <= 40)
    {
        group4 += group;
    }
    else if (group >= 41)
    {
        group5 += group;
    }
}
totalClimbers = group1 + group2 + group3 + group4 + group5;

Console.WriteLine($"{(group1 != 0 ? (group1 / (double)totalClimbers * 100) : 0):f2}%");
Console.WriteLine($"{(group2 != 0 ? (group2 / (double)totalClimbers * 100) : 0):f2}%");
Console.WriteLine($"{(group3 != 0 ? (group3 / (double)totalClimbers * 100) : 0):f2}%");
Console.WriteLine($"{(group4 != 0 ? (group4 / (double)totalClimbers * 100) : 0):f2}%");
Console.WriteLine($"{(group5 != 0 ? (group5 / (double)totalClimbers * 100) : 0):f2}%");
