string item = Console.ReadLine();
string dayOfWeek = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double price = 0.0;
if (
    dayOfWeek == "Monday"
    || dayOfWeek == "Tuesday"
    || dayOfWeek == "Wednesday"
    || dayOfWeek == "Thursday"
    || dayOfWeek == "Friday"
)
{
    if (item == "banana")
    {
        price = 2.50;
    }
    else if (item == "apple")
    {
        price = 1.20;
    }
    else if (item == "orange")
    {
        price = 0.85;
    }
    else if (item == "grapefruit")
    {
        price = 1.45;
    }
    else if (item == "kiwi")
    {
        price = 2.70;
    }
    else if (item == "pineapple")
    {
        price = 5.50;
    }
    else if (item == "grapes")
    {
        price = 3.85;
    }
    else
    {
        Console.WriteLine("error");
        return;
    }
    Console.WriteLine($"{(price * quantity):f2}");
}
else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
{
    if (item == "banana")
    {
        price = 2.70;
    }
    else if (item == "apple")
    {
        price = 1.25;
    }
    else if (item == "orange")
    {
        price = 0.90;
    }
    else if (item == "grapefruit")
    {
        price = 1.60;
    }
    else if (item == "kiwi")
    {
        price = 3.00;
    }
    else if (item == "pineapple")
    {
        price = 5.60;
    }
    else if (item == "grapes")
    {
        price = 4.20;
    }
    else
    {
        Console.WriteLine("error");
        return;
    }
    Console.WriteLine($"{(price * quantity):f2}");
}
else
{
    Console.WriteLine("error");
}
