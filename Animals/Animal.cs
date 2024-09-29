namespace OOP___Arv.Animals;

public abstract class Animal
{
    //Properties of each animal
    public string Name { get; set; }
    public string Species { get; set; }
    public string Diet { get; set; }
    public string Habitat { get; set; }
    public int Age { get; set; }

    //Constructor to initialize base-class
    public Animal(string name, string species, string diet, string habitat, int age)
    {
        Name = name;
        Species = species;
        Diet = diet;
        Habitat = habitat;
        Age = age;
    }

    //Abstract methods, implemented by each subclass
    public abstract void MakeSound();
    public abstract void Move();
    public abstract void Eat();
}