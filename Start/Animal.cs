using System.Drawing;

namespace Start;
public class Animal
{
    public string Cat = string.Empty; //Define String
    public string Color { get; set; } //Define property
    public int Age { get; set; } //Define property

    public Animal()  //Constructor template
    {
        Console.WriteLine("This is a cat");

    }
    public void AgeOfTheCat()  //Constructor template
    {
        Console.WriteLine("The age of the cat is 5 years old");

    }
    public void PrintAgeOfTheCat(string Age)  //Constructor template
    {
        Console.WriteLine($"The cat have {Age} years old");

    }
    public string HowOldIsTheCat()
    {
        return $"The age of the cat is {Age}";
    }

    public void TheColorOfTheCat()
    {
        Color = "Black";
    }

}