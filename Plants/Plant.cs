namespace OOP___Arv.Plants;

//Abstract baseclass for all plants
public abstract class Plant
{
    //Base properties for all plants
    public string Name { get; set; }
    public string Type { get; set; }

    //Constructor to initialize a plant
    public Plant(string name, string type)
    {
        Name = name;
        Type = type;
    }

    //Abstract method for plants, implemented by subclass
    public abstract void Grow();
}

//Subclass inherited by baseclass Plant
public class Tree : Plant
{
    //Properties of this object
    public int Height { get; set; }

    //Constructor to initialize object
    public Tree() : base("Oak", "Tree")
    {
        Height = 12; //Meters
    }

    //Implement abstract method
    public override void Grow()
    {
        Console.WriteLine($"The {Name} has grown taller.");
    }
}

//Subclass inherited by baseclass Plant
public class Flower : Plant
{
    //Properties of this object
    public string Color { get; set; }

    //Constructor to initialize object
    public Flower() : base("Bellflower", "Flower")
    {
        Color = "Blue";
    }

    //Implement abstract method
    public override void Grow()
    {
        Console.WriteLine($"The {Name} blooms.");
    }
}