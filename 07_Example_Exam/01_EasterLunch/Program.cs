double easternBreadPrice = 3.20;
double eggPricePerBox = 4.35;
double easternCookiesPerKilo = 5.40;
double eggPaintPerEgg = 0.15;

double easternBreads = double.Parse(Console.ReadLine());
double boxEggs = double.Parse(Console.ReadLine());
double kilosEasternCookies = double.Parse(Console.ReadLine());

double easternBreadTotalPrice = easternBreads * easternBreadPrice;
double eggsTotalPrice = eggPricePerBox * boxEggs;
double easternCookiesTotalPrice = easternCookiesPerKilo * kilosEasternCookies;
double pricePaintingTotalPrice = boxEggs * 12 * eggPaintPerEgg;

double total =
    easternBreadTotalPrice + eggsTotalPrice + easternCookiesTotalPrice + pricePaintingTotalPrice;
Console.WriteLine($"{total:f2}");
