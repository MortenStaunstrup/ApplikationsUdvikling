namespace Modul6;

public class Yatzy
{
    private DiceCup Cup;
    private List<int> beholdteTerninger;

    public Yatzy()
    {
        Cup = new DiceCup(5);
    }

    public void KastOgVisTerninger()
    {
        Cup.Ryst();
        Cup.VisØjne();
    }

    public void BeholdTerninger(int amount, List<int> indexForDice)
    {
        List<int> Dice = Cup.GetDiceEyes();
        
        for (int i = 0; i < amount; i++)
        {
            beholdteTerninger.Add(Dice[indexForDice[i]]);
        }
        Cup = new DiceCup(5 - amount);
    }

    public List<int> GetBeholdteTerninger()
    {
        return beholdteTerninger;
    }

    public void TømBeholdteTerninger()
    {
        beholdteTerninger = new List<int>();
        Cup = new DiceCup(5);
    }

    public List<int> AmountOfEyes(List<int> beholdteTerninger)
    {
        int ones = 0, twos = 0, threes = 0, fours = 0, fives = 0, sixes = 0;
        List<int> AmountOfEyes = new List<int>();
        
        for (int i = 0; i < beholdteTerninger.Count; i++)
        {
            switch (beholdteTerninger[i])
            {
                case 1:
                    ones++;
                    break;
                case 2:
                    twos++;
                    break;
                case 3:
                    threes++;
                    break;
                case 4:
                    fours++;
                    break;
                case 5:
                    fives++;
                    break;
                case 6:
                    sixes++;
                    break;
            }
        }

        AmountOfEyes.AddRange(ones, twos, threes, fours, fives, sixes);
        return AmountOfEyes;
    }
    
    public int EtPar(List<int> AmountOfEyes)
    {
        
        if (AmountOfEyes[0] > 1)
        {
            return 2;
        } else if (AmountOfEyes[1] > 1)
        {
            return 4;
        } else if (AmountOfEyes[2] > 1)
        {
            return 6;
        } else if (AmountOfEyes[3] > 1)
        {
            return 8;
        } else if (AmountOfEyes[4] > 1)
        {
            return 10;
        } else if (AmountOfEyes[5] > 1)
        {
            return 12;
        }
        else
        {
            return 0;
        }
    }
    
}