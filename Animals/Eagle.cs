using OOP___Arv.Interfaces;

namespace OOP___Arv.Animals;

public class Eagle : Animal, IWildAnimal
{
    //New property for eagles
    public bool CanFly { get; set; }

    //Constructor to initialize an eagle
    public Eagle(string name, int age, bool canFly)
        : base(name, "Eagle", "Carnivore", "Mountains", age)
    {
        CanFly = canFly;
    }
    
    //Implement abstract methods from baseclass
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}, the {Species}, makes a loud screech!");
    }

    public override void Move()
    {
        if (CanFly)
        {
            Console.WriteLine($"{Name} the {Species} soars around the {Habitat}.");
        }
        else
        {
            Console.WriteLine($"{Name} the {Species} is hurt and can't fly.");
        }
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the {Species} is eating a mouse.");
    }
    
    //Implement Hunt for eagles
    public void Hunt()
    {
        Console.WriteLine($"{Name} is hunting for food");
    }

    //New method for eagles
    public void Dive()
    {
        if (CanFly)
        {
            Console.WriteLine($"{Name} the {Species} is taking a dive from a high altitude.");
        }
        else
        {
            Console.WriteLine($"{Name} the {Species} is unable to fly.");
        }
    }
}