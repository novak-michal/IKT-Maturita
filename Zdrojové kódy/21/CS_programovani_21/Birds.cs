namespace CS_programovani_21;

public class Birds : Animal
{
    public double eggVolume;

    public Birds(double weight, double height, string name, double eggVolume) : base(weight, height, name)
    {
        //base.Height = height; kdybych chtěl něco ukládat do rodiče, ale je lepší použít zápis ↑
        this.eggVolume = eggVolume;
    }
    
}