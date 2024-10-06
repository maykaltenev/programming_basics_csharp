string product = Console.ReadLine();
string town = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double cost = 0.0;
if (town == "Sofia")
{
    if (product == "coffee")
    {
        cost = 0.50;
    }
    else if (product == "water")
    {
        cost = 0.80;
    }
    else if (product == "beer")
    {
        cost = 1.20;
    }
    else if (product == "sweets")
    {
        cost = 1.45;
    }
    else if (product == "peanuts")
    {
        cost = 1.60;
    }
}
else if (town == "Plovdiv")
{
    if (product == "coffee")
    {
        cost = 0.40;
    }
    else if (product == "water")
    {
        cost = 0.70;
    }
    else if (product == "beer")
    {
        cost = 1.15;
    }
    else if (product == "sweets")
    {
        cost = 1.30;
    }
    else if (product == "peanuts")
    {
        cost = 1.50;
    }
}
else if (town == "Varna")
{
    if (product == "coffee")
    {
        cost = 0.45;
    }
    else if (product == "water")
    {
        cost = 0.70;
    }
    else if (product == "beer")
    {
        cost = 1.10;
    }
    else if (product == "sweets")
    {
        cost = 1.35;
    }
    else if (product == "peanuts")
    {
        cost = 1.55;
    }
}

Console.WriteLine(cost * quantity);
