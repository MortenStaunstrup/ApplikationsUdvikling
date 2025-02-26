namespace Modul7;

public class Terning
{
    protected int size;
    protected int eyes;
    protected Random random;

    public Terning(int size = 6)
    {
        random = new Random();
        if (size < 1)
        {
            Console.WriteLine("Size must be greater than 0, Size set to 1");
            this.size = 1;
        } else
            this.size = size;
        this.eyes = random.Next(size) + 1;
    }

    public int GetDice()
    {
        return this.eyes;
    }

    public virtual void Ryst()
    {
        
    }
    
    
}