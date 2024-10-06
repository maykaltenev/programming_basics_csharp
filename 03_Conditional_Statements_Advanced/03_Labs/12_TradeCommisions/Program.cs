string town = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());

double commission = 0.0;

if (sales < 0)
{
    Console.WriteLine("error");
    return;
}

if (town == "Sofia")
{
    if (sales >= 0 && sales <= 500)
    {
        commission = 0.05;
    }
    else if (sales > 500 && sales <= 1000)
    {
        commission = 0.07;
    }
    else if (sales > 1000 && sales <= 10000)
    {
        commission = 0.08;
    }
    else if (sales > 10000)
    {
        commission = 0.12;
    }
}
else if (town == "Varna")
{
    if (sales >= 0 && sales <= 500)
    {
        commission = 0.045;
    }
    else if (sales > 500 && sales <= 1000)
    {
        commission = 0.075;
    }
    else if (sales > 1000 && sales <= 10000)
    {
        commission = 0.10;
    }
    else if (sales > 10000)
    {
        commission = 0.13;
    }
}
else if (town == "Plovdiv")
{
    if (sales >= 0 && sales <= 500)
    {
        commission = 0.055;
    }
    else if (sales > 500 && sales <= 1000)
    {
        commission = 0.08;
    }
    else if (sales > 1000 && sales <= 10000)
    {
        commission = 0.12;
    }
    else if (sales > 10000)
    {
        commission = 0.145;
    }
}
else
{
    Console.WriteLine("error");
    return;
}

Console.WriteLine($"{(commission * sales):f2}");
