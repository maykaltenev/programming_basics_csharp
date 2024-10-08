int count = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 0; i < count; i++)
{
    int newNumber = int.Parse(Console.ReadLine());
    sum += newNumber;
}
Console.WriteLine(sum);
