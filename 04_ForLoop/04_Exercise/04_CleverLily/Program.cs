int age = int.Parse(Console.ReadLine());
double priceWashingMachine = double.Parse(Console.ReadLine());
int priceToys = int.Parse(Console.ReadLine());

int sumToys = 0;
int sumSaved = 0;
int countEvenBirthdays = 1;
for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0)
    {
        sumSaved += countEvenBirthdays * 10;
        countEvenBirthdays++;
        sumSaved--;
    }
    else
    {
        sumToys += priceToys;
    }
}

double total = sumSaved + sumToys;
if (total >= priceWashingMachine)
{
    Console.WriteLine($"Yes! {(total - priceWashingMachine):f2}");
}
else
{
    Console.WriteLine($"No! {(priceWashingMachine - total):f2}");
}
