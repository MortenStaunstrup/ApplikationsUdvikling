namespace Modul6;

public class DiceCup
{
    private Dice[] dice;
    
    public DiceCup(int amountOfDice = 2)
    {
        if (amountOfDice < 0)
        {
            Console.WriteLine("Invalid amount of dice, dice amount set to 1");
            amountOfDice = 1;
        }
        
        dice = new Dice[amountOfDice];
        for (int i = 0; i < amountOfDice; i++)
        {
            dice[i] = new Dice();
        }
    }

    public void Ryst()
    {
        foreach (var die in dice)
        {
            die.Roll();
        }
    }

    public List<int> GetDiceEyes()
    {
        List<int> result = new List<int>();
        foreach (var die in dice)
        {
            result.Add(die.getDice());
        }
        return result;
    }

    public void VisØjne()
    {
        foreach (var die in dice)
        {
            Console.Write($"[{die.getDice()}] ");
        }
    }
    
}