using OOP___Arv.Animals;
using OOP___Arv.Humans;
using OOP___Arv.Plants;

namespace OOP___Arv
{
// Mowitz Almstedt .NET24 //

/*=======================================
 * In this program I've tried working
 * with abstract classes, subclasses and
 * interfaces to create different objects
 * with standard properties and methods
 * as well as unique ones added by each
 * subclass. Each class is categorized
 * for easier readability.
 ========================================*/

   public class Program
    {
        public static void Main(string[] args)
        {
            //Create an instance of each object
            Cow Betty = new Cow("Betty", 7, true);
            Cow King = new Cow("King", 7, false);
            Bulldog Bruno = new Bulldog("Bruno", 12, true);
            Chihuahua Chico = new Chihuahua("Chico", 14, true);
            Eagle Zephyr = new Eagle("Zephyr", 14, true);
            Lion Simba = new Lion("Simba", 9, true);
            Lion Nala = new Lion("Nala", 5, false);

            Human Reidar = new Human("Reidar", "Nilsen", 64);

            Tree OakTree = new Tree();
            Flower Bellflower = new Flower();

            //Call one of the methods present in each object
            Betty.MakeSound();
            Bruno.MakeSound();
            Chico.MakeSound();
            Zephyr.MakeSound();
            Simba.MakeSound();

            Console.WriteLine("");
            Reidar.MakeSound();
            Reidar.Think();

            Console.WriteLine("");
            OakTree.Grow();
            Bellflower.Grow();

        }
    }
}