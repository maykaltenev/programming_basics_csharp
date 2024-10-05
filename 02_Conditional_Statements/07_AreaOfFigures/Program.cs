string figureName = Console.ReadLine();

if (figureName == "square")
{
    double width = double.Parse(Console.ReadLine());
    double area = width * width;
    Console.WriteLine($"{area:f3}");
}
else if (figureName == "rectangle")
{
    double width = double.Parse(Console.ReadLine());
    double length = double.Parse(Console.ReadLine());
    double area = width * length;
    Console.WriteLine($"{area:f3}");
}
else if (figureName == "circle")
{
    double radius = double.Parse(Console.ReadLine());

    double area = radius * radius * Math.PI;
    Console.WriteLine($"{area:f3}");
}
else if (figureName == "triangle")
{
    double width = double.Parse(Console.ReadLine());
    double length = double.Parse(Console.ReadLine());
    double area = width * length / 2;
    Console.WriteLine($"{area:f3}");
}
else
{
    Console.WriteLine($"Unknown Figure");
}
