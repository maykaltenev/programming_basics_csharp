double yearlyPriceBasketballTraining = double.Parse(Console.ReadLine());

double shoes = yearlyPriceBasketballTraining - (yearlyPriceBasketballTraining * 0.40);
double clothes = shoes - (shoes * 0.20);
double ball = clothes * 0.25;
double accessories = ball * 0.20;
double total = yearlyPriceBasketballTraining + shoes + clothes + ball + accessories;

Console.WriteLine(total);
