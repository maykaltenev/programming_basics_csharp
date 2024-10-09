int firstNumber = int.Parse(Console.ReadLine());

int sum = 0;
while (sum < firstNumber)
{
    int number = int.Parse(Console.ReadLine());
    sum += number;
}

Console.WriteLine(sum);
