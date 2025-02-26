namespace Modul5;

public class Opgave_5_2
{
    public void run(int kast, int chanceForSix)
    {
        MafiaDice dice = new MafiaDice();

        int one = 0, two = 0, three = 0, four = 0, five = 0, six = 0;
        
        int i = 0;
        while (i < kast)
        {
            dice.ryst(chanceForSix);
            switch (dice.skriv())
            {
                case 1:
                    one++;
                    break;
                case 2:
                    two++;
                    break;
                case 3:
                    three++;
                    break;
                case 4:
                    four++;
                    break;
                case 5:
                    five++;
                    break;
                case 6:
                    six++;
                    break;
            }

            i++;
        }
        
        Console.WriteLine($"Terning kastet {kast} gange");
        Console.WriteLine($"Antal 1: {one}\nAntal 2: {two}\nAntal 3: {three}\nAntal 4: {four}\nAntal 5: {five}\nAntal 6: {six}");
        
    }
}