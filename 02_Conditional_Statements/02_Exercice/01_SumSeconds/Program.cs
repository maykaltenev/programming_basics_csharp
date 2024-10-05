int inputOne = int.Parse(Console.ReadLine());
int inputTwo = int.Parse(Console.ReadLine());
int inputThree = int.Parse(Console.ReadLine());

int total = inputOne + inputTwo + inputThree;
int minutes = total / 60;
int seconds = total % 60;
if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}
