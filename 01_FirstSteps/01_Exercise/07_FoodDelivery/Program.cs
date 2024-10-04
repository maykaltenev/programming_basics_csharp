double numberChickenMenu = double.Parse(Console.ReadLine());
double numberFishMenu = double.Parse(Console.ReadLine());
double numberVegetarianMenu = double.Parse(Console.ReadLine());

double priceChickenMenu = numberChickenMenu * 10.35;

double priceFishMenu = numberFishMenu * 12.40;
double priceVegetarianMenu = numberVegetarianMenu * 8.15;

double priceMenus = priceChickenMenu + priceFishMenu + priceVegetarianMenu;

double priceDeserts = priceMenus * 0.20;

double priceDelivery = 2.50;

double totalSum = priceMenus + priceDeserts + priceDelivery;

Console.WriteLine(totalSum);
