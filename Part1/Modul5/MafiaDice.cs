namespace Modul5;

public class MafiaDice
{
    private int Eyes;
    private Random rnd;

    public MafiaDice(int eyes = 1)
    {
        if (eyes < 1 || eyes > 6)
        {
            Console.WriteLine("Error: Value must be between 1 and 6\nValue has been set to 1");
            this.Eyes = 1;
        }else
            this.Eyes = eyes;
    }

    public void ryst(int pcChanceForSix)
    {  
        rnd = new Random();
        int six = rnd.Next(1, 101);

        if (six <= pcChanceForSix)
        {
            this.Eyes = 6;
        } else
        {
            this.Eyes = rnd.Next(1, 6);
        }
    }

    public int skriv()
    {
        return this.Eyes;
    }
}