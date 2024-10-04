double dogFood = 2.50;
int catFood = 4;
int packageDogFood = int.Parse(Console.ReadLine());
int packageCatFood = int.Parse(Console.ReadLine());
double totalDogFood = dogFood * packageDogFood;
double totalCatFood = catFood * packageCatFood;
double totalFood = totalCatFood + totalDogFood;
Console.WriteLine($"{totalFood} lv.");
