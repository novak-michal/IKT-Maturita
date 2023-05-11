namespace CS_programovani_21;

/*Takhle třída mi bude sloužit jako rodič - budu z ní dědit vlastnosti,atributy,metody */
public class Animal
{
    private double Weight;
    public double Height;
    internal string Name;

    public Animal(double weight, double height, string name)
    {
        Weight = weight;
        Height = height;
        Name = name;
    }

    public Animal()
    {
        
    }

    /* Takhle se dá taky zapsat setter, ale nedělám tu žádnou kontrolu
    public double Weight => Weight;
    */
    public double GetHeight()
    {
        return Height;
    }
    public double GetWeight()
    {
        return Weight;
    }
    public string GetName()
    {
        return Name;
    }
    public void SetHeight(int Height)
    {
        if (Height != null && Height > 0)
        {
            this.Height = Height;
        }
        else
        {
            Console.WriteLine("Nepodařilo se nastavit výšku.");
        }
    }
    public void SetWeight(double Weight)
    {
        if (Weight != null && Weight > 0)
        {
            this.Weight = Weight;
        }
    }
    public void SetName(string name)
    {
        if (name != null && name.Length > 1)
        {
            this.Name = name;
        }
        else
        {
            Console.WriteLine("Zadané jméno bylo null nebo má jenom 1 znak");
        }
    }

    public virtual void FeedAnimal()
    {
        Console.WriteLine("Giving some grass to animal " + Name);
    }
    
}