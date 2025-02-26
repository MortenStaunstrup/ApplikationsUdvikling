namespace Modul7;

public class Dice : Terning
{
    public override void Ryst()
    {
        random = new Random();
        eyes = random.Next(size) + 1;
    }
}