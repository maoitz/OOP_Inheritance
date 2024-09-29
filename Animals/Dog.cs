using OOP___Arv.Interfaces;

namespace OOP___Arv.Animals;

public class Dog : Animal, IDomesticAnimal
{
    //New property for dogs
    public bool IsLoyal { get; set; }

    //Constructor to initialize a dog
    public Dog(string name, int age, bool isLoyal) //Allows custom values when creating this object
        : base(name, "Dog", "Omnivore", "Home", age) //Set base values
    {
        IsLoyal = isLoyal;
    }
    
    //Implement abstract methods from baseclass
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}, the {Species}, barks!");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the {Species} is running around {Habitat}.");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the {Species} is eating kibble.");
    }
    
    //New method for dogs
    public void Fetch()
    {
        Console.WriteLine($"{Name} the {Species} fetches the ball.");
    }
    
    //Implement BeFriendly for dogs
    public void BeFriendly()
    {
        Console.WriteLine($"{Name} wags its tail and barks happily!");
    }
}

//Inheritance class from subclass created by a baseclass, added interface
public class Bulldog : Dog, IDomesticAnimal
{
    //New property for subclass bulldog in class dog
    public bool Snores { get; set; }
    public new string Species { get; set; }

    public Bulldog(string name, int age, bool isLoyal) //Allow custom values
        : base(name, age, isLoyal) //Set base values from inheritance class
    {
        Snores = true;
        Species = "Bulldog";
    }
    //Implement abstract methods from baseclass
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}, the {Species}, grunts and snorts.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the {Species} is playing at {Habitat}.");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the {Species} is eating!");
    }
    
    //New method for bulldogs
    public void Snore()
    {
        Console.WriteLine($"{Name} the {Species} is snoring loudly while sleeping.");
    }
}

//Inheritance class from a subclass created by a baseclass, added interface
public class Chihuahua : Dog, IDomesticAnimal
{
    //New property for chihuahuas
    public bool IsTiny  { get; set; }
    public new string Species { get; set; }

    //Constructor to initialize a chihuahua
    public Chihuahua(string name, int age, bool isLoyal)
        : base(name, age, isLoyal)
    {
        IsTiny = true;
        Species = "Chihuahua";
    }
    
    //Implement abstract methods from baseclass
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}, the {Species}, lets out a tiny bark!");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the {Species} jumps around at {Habitat}.");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the {Species} eats his dogfood.");
    }

    //New method for chihuahuas
    public void Shake()
    {
        Console.WriteLine($"{Name} the {Species} is shaking nervously.");
    }
}