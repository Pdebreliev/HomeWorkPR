using Start.BasicOOP;
using Start.Intermediate_OOP;

Animal AnimalStepClass = new();
AnimalStepClass.Color = "black";
AnimalStepClass.Age = 5;

Console.WriteLine("The color of the cat is "+ AnimalStepClass.Color);
Console.WriteLine("The cat is " + AnimalStepClass.Age + " years old");

Console.WriteLine(StaticClass.GetMeSomeBuilding());
StaticClass.Buildings = "I have a house";

Console.WriteLine(StaticClass.Buildings);


WeeklyWalksForOurDog weeklyWalksForOurDogClas = new();
Console.WriteLine(weeklyWalksForOurDogClas.text);
