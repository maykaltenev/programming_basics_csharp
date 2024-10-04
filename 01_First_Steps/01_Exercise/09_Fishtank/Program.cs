double length = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

double volume = length * width * height;
double volumeInLiters = volume * 0.001;
double takenSpace = percent / 100;
double litersNeeded = volumeInLiters * (1 - takenSpace);

Console.WriteLine(litersNeeded);
