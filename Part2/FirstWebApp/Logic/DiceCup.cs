namespace FirstWebApp.Logic;

public class DiceCup
{
    private Dice[] cup;

    public DiceCup(int diceCount)
    {
        cup = new Dice[diceCount];
        for (int i = 0; i < diceCount; i++)
        {
            cup[i] = new Dice(6);
        }
    }

    public void Shake()
    {
        foreach (var dice in cup)
        {
            dice.Roll();
        }
    }

    public List<int> GetEyes()
    {
        List<int> eyes = new List<int>();
        foreach (var dice in cup)
        {
            eyes.Add(dice.GetDice());
        }
        return eyes;
    }
    
}