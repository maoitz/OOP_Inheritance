using OOP___Arv.Animals;

namespace OOP___Arv.Humans;

public class Human : Animal
{
    //New properties for a human
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //Constructor to initialize a human with custom age, first, and lastname
    public Human(string name, string lastName, int age)
        : base(name, "Human", "Omnivore", "Home", age)
    {
        FirstName = name;
        LastName = lastName;
    }
    
    //Implement abstract methods from baseclass
    public override void MakeSound()
    {
        Console.WriteLine($"{FirstName} {LastName} is speaking!");
    }

    public override void Move()
    {
        Console.WriteLine($"{FirstName} {LastName} is walking around.");
    }

    public override void Eat()
    {
        Console.WriteLine($"{FirstName} {LastName} is eating a home-cooked meal!");
    }

    //New method for humans
    public void Think()
    {
        Console.WriteLine($"{FirstName} {LastName} is thinking about C# and .NET");
    }
}