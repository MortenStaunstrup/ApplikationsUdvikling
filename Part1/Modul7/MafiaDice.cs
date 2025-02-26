namespace Modul7;

public class MafiaDice : Terning
{
    private int pcChanceForSix;

    public MafiaDice(int pcChangeForSix)
    {
        this.pcChanceForSix = pcChangeForSix;
    }
    
    
    public override void Ryst()
    {
        random = new Random();
        int six = random.Next(1, 101);

        this.eyes = six <= pcChanceForSix ? 6 : random.Next(1, 6);
    }

    public void changeChance(int chance)
    {
        this.pcChanceForSix = chance;
    }
}