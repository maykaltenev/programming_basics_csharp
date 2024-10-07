string month = Console.ReadLine();
int numberOfDays = int.Parse(Console.ReadLine());

double priceStudio = 1;
double priceApartment = 1;
double studioDiscount = 1;
double apartmentDiscount = 1;
if (month == "May" || month == "October")
{
    priceStudio = 50;
    priceApartment = 65;

    if (numberOfDays > 7 && numberOfDays < 14)
    {
        studioDiscount = 0.95;
    }
    else if (numberOfDays > 14)
    {
        studioDiscount = 0.70;
        apartmentDiscount = 0.90;
    }
}
else if (month == "June" || month == "September")
{
    priceStudio = 75.20;
    priceApartment = 68.70;
    if (numberOfDays > 14)
    {
        studioDiscount = 0.80;
        apartmentDiscount = 0.90;
    }
}
else if (month == "July" || month == "August")
{
    priceStudio = 76;
    priceApartment = 77;

    if (numberOfDays > 14)
    {
        apartmentDiscount = 0.90;
    }
}

double resultStudio = priceStudio * numberOfDays * studioDiscount;
double resultApartment = priceApartment * numberOfDays * apartmentDiscount;
Console.WriteLine($"Apartment: {resultApartment:f2} lv.");
Console.WriteLine($"Studio: {resultStudio:f2} lv.");
