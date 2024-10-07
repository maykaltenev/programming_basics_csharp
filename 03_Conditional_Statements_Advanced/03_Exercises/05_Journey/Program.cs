double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string destination = "";
string location = "";

if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer")
    {
        location = "Camp";
        budget *= 0.30;
    }
    else if (season == "winter")
    {
        location = "Hotel";
        budget *= 0.70;
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";
    if (season == "summer")
    {
        location = "Camp";
        budget *= 0.40;
    }
    else if (season == "winter")
    {
        location = "Hotel";
        budget *= 0.80;
    }
}
else if (budget > 1000)
{
    destination = "Europe";
    location = "Hotel";
    budget *= 0.90;
}
else { }

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{location} - {budget:f2}");
