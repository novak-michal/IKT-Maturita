namespace CS_programovani_21;

public class Mammal : Animal
{
    public Mammal mother;
    public Mammal father;

    public Mammal(double weight, double height, string name, Mammal mother, Mammal father) : base(weight, height, name)
    {
        this.mother = mother;
        this.father = father;
    }

    public Mammal()
    {
    }

    public override void FeedAnimal()
    {
        Console.WriteLine("Feeding mammal with milk");
    }
}
