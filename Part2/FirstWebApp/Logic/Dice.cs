namespace FirstWebApp.Logic;

public class Dice
{
    public int eyes;
    public int size;
    public Random rnd = new Random();

    public Dice(int size)
    {
        this.size = size;
        this.eyes = rnd.Next(size) + 1;
    }

    public void Roll()
    {
        eyes = rnd.Next(size) + 1;
    }

    public int GetDice()
    {
        return eyes;
    }
    
}