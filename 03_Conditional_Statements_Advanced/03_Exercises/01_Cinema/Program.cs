string typeCinema = Console.ReadLine();
int r = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

double price = 0.0;
if (typeCinema == "Premiere")
{
    price = 12.00;
}
else if (typeCinema == "Normal")
{
    price = 7.50;
}
else if (typeCinema == "Discount")
{
    price = 5.00;
}

double total = r * c * price;

Console.WriteLine($"{total:f2} leva");
