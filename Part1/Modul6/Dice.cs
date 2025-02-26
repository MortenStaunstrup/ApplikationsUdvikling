namespace Modul6;

public class Dice
{
    private int eyes;
    private int size;

    private Random random;
    
    public Dice(int size = 6)
    {
        this.size = size;
        random = new Random();
        Roll();
    }

    public void Roll()
    {
        eyes = random.Next(size) + 1;
    }

    public int getDice()
    {
        return eyes;
    }
}