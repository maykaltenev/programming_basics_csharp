double firstDays = double.Parse(Console.ReadLine());
string accommodationSpace = Console.ReadLine();
string review = Console.ReadLine();
double discount = 1.0;
double result = 0.0;
double days = firstDays - 1;
if (accommodationSpace == "apartment")
{
    if (days < 10)
    {
        discount = 0.70;
    }
    else if (days >= 10 && days < 15)
    {
        discount = 0.65;
    }
    else if (days > 15)
    {
        discount = 0.50;
    }

    result = days * 25 * discount;
}
else if (accommodationSpace == "president apartment")
{
    if (days < 10)
    {
        discount = 0.90;
    }
    else if (days >= 10 && days < 15)
    {
        discount = 0.85;
    }
    else if (days > 15)
    {
        discount = 0.80;
    }
    result = days * 35 * discount;
}
else if (accommodationSpace == "room for one person")
{
    result = days * 18;
}

if (review == "positive")
{
    result = result * 1.25;
}
else if (review == "negative")
{
    result = result * 0.90;
}
Console.WriteLine($"{result:f2}");
