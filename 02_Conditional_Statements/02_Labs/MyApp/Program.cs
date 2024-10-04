// string number = "string";

// int a = 5;
// int b = 2;
// double result = a / b;

// Console.WriteLine(result);
// int a = 5;
// string number = "5";


double number = double.Parse(Console.ReadLine());

Console.WriteLine($"Math.Floor-> {Math.Floor(number)}");
Console.WriteLine($"Math.Ceiling-> {Math.Ceiling(number)}");
Console.WriteLine($"Math.Truncate-> {Math.Truncate(number)}");
Console.WriteLine($"Math.Round up to 1 digit-> {Math.Round(number, 1)}");
Console.WriteLine($"Formatting up to 1 digit-> {number:f5}");
