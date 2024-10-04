double neededQuantityNylon = double.Parse(Console.ReadLine());
double neededQuantityPaint = double.Parse(Console.ReadLine());
double neededQuantityThinner = double.Parse(Console.ReadLine());
double workedTimed = double.Parse(Console.ReadLine());

double priceNylon = (neededQuantityNylon + 2) * 1.50;

double pricePaint = (neededQuantityPaint + (neededQuantityPaint * 0.10)) * 14.50;

double priceThinner = neededQuantityThinner * 5;

double priceBag = 0.40;

double totalCostMaterial = priceNylon + pricePaint + priceThinner + priceBag;
double costWorkers = (totalCostMaterial * 0.30) * workedTimed;

double totalSum = totalCostMaterial + costWorkers;

Console.WriteLine(totalSum);
