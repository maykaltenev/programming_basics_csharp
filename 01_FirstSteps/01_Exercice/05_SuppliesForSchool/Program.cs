double pens = double.Parse(Console.ReadLine());
double markers = double.Parse(Console.ReadLine());
double cleaningMaterial = double.Parse(Console.ReadLine());
double discount = double.Parse(Console.ReadLine());

double pricePens = pens * 5.80;
double priceMarkers = markers * 7.20;
double priceCleaningMaterial = cleaningMaterial * 1.20;
double priceAllMaterial = pricePens + priceMarkers + priceCleaningMaterial;

double discountAsRealNumber = discount / 100;

double priceWithDiscount = priceAllMaterial - (priceAllMaterial * discountAsRealNumber);

Console.WriteLine(priceWithDiscount);
