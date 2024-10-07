double numberOne = double.Parse(Console.ReadLine());
double numberTwo = double.Parse(Console.ReadLine());
string operation = Console.ReadLine();
double result = 0.0;

string oddOrEven = "";

if (operation == "+")
{
    result = numberOne + numberTwo;

    if (result % 2 == 0)
    {
        oddOrEven = "even";
    }
    else
    {
        oddOrEven = "odd";
    }
    Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - {oddOrEven}");
}
else if (operation == "/")
{
    if (numberOne == 0 || numberTwo == 0)
    {
        double notZero = numberOne == 0 ? numberTwo : numberOne;
        Console.WriteLine($"Cannot divide {notZero} by zero");
    }
    else
    {
        result = numberOne / numberTwo;
        Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result:f2}");
    }
}
else if (operation == "-")
{
    result = numberOne - numberTwo;

    if (result % 2 == 0)
    {
        oddOrEven = "even";
    }
    else
    {
        oddOrEven = "odd";
    }
    Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - {oddOrEven}");
}
else if (operation == "%")
{
    if (numberOne == 0 || numberTwo == 0)
    {
        double notZero = numberOne == 0 ? numberTwo : numberOne;
        Console.WriteLine($"Cannot divide {notZero} by zero");
    }
    else
    {
        result = numberOne % numberTwo;
        Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result}");
    }
}
else if (operation == "*")
{
    result = numberOne * numberTwo;

    if (result % 2 == 0)
    {
        oddOrEven = "even";
    }
    else
    {
        oddOrEven = "odd";
    }
    Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - {oddOrEven}");
}
