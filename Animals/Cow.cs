using OOP___Arv.Interfaces;

namespace OOP___Arv.Animals;

public class Cow : Animal, IDomesticAnimal
{
    //Unique property for cows
    public bool HasMilk { get; set; }

    //Constructor to initialize object
    public Cow(string name, int age, bool hasMilk) //Allow for custom values when creating this object
        : base(name, "Cow", "Herbivore", "Farm", age) //Set base values
    {
        HasMilk = hasMilk;
    }
    
    //Implement abstract methods from baseclass
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}, the {Species}, moos!");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the {Species} wanders the {Habitat}.");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the {Species} is eating grass.");
    }

    //New method for cows
    public void Milk()
    {
        if (HasMilk == true)
        {
            Console.WriteLine($"{Name} has produced milk.");
        }
        else
        {
            Console.WriteLine($"{Name} has not produced any milk.");
        }
    }

    //Implement BeFriendly for cows
    public void BeFriendly()
    {
        Console.WriteLine($"{Name} is being gentle and friendly.");
    }
}