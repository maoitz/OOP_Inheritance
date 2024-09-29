using OOP___Arv.Interfaces;

namespace OOP___Arv.Animals;

public class Lion : Animal, IWildAnimal
{
    //New property for lions
    public bool IsAlpha { get; set; }

    //Constructor to initialize a lion
    public Lion(string name, int age, bool isAlpha)
        : base(name, "Lion", "Carnivore", "Savannah", age)
    {
        IsAlpha = isAlpha;
    }

    //Implement abstract methods from baseclass
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}, the {Species}, gives a loud roar!");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the {Species} prowls the {Habitat}");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the {Species} devour its prey.");
    }
    
    //Implement Hunt for lions
    public void Hunt()
    {
        Console.WriteLine($"{Name} is out hunting.");
    }
    
    //New method for lions
    public void LeadPride()
    {
        if (IsAlpha)
        {
            Console.WriteLine($"{Name} the {Species} is leading its pride");
        }
        else
        {
            Console.WriteLine($"{Name} the {Species} is following the alpha");
        }
    }
}