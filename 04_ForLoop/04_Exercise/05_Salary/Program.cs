int numberTabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

for (int i = 0; i < numberTabs; i++)
{
    string nameWebsite = Console.ReadLine();

    if (nameWebsite == "Facebook")
    {
        salary -= 150;
    }
    else if (nameWebsite == "Instagram")
    {
        salary -= 100;
    }
    else if (nameWebsite == "Reddit")
    {
        salary -= 50;
    }
    else { }

    if (salary <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        return;
    }
}
Console.WriteLine(salary);
