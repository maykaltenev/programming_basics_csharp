string input = Console.ReadLine();

int grade = 0;
double total = 0;
int fails = 0;
string name = input;
while (grade < 12)
{
    double score = double.Parse(Console.ReadLine());
    if (score < 4)
    {
        fails++;
        if (fails >= 2)
        {
            Console.WriteLine($"{name} has been excluded at {grade} grade");
            break;
        }
    }
    total += score;
    grade++;
}
if (grade == 12)
{
    Console.WriteLine($"{name} graduated. Average grade: {(total / grade):f2}");
}
