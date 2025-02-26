namespace Modul7;

public class DiceCup
{
    private Terning[] diceCup;
    
    public DiceCup(int amountOfDice = 2, int amountOfMafia = 2, int chanceForMafiaDice = 16)
    {
        if (amountOfDice < 0 && amountOfMafia < 0)
        {
            Console.WriteLine("Invalid amount of dice, dice amount set to 1");
            amountOfDice = 1;
        }
        
        diceCup = new Terning[amountOfDice + amountOfMafia];
        int i = 0;

        while (i < amountOfDice)
        {
            diceCup[i] = new Dice();
            i++;
        }

        for (int j = i; j < amountOfMafia + amountOfDice; j++)
        {
            diceCup[j] = new MafiaDice(chanceForMafiaDice);
        }
    }

    public void Roll()
    {
        foreach (var dice in diceCup)
        {
            dice.Ryst();
        }
    }

    public List<int> GetDiceEyes()
    {
        List<int> eyes = new List<int>();
        foreach (var dice in diceCup)
        {
            eyes.Add(dice.GetDice());
        }
        return eyes;
    }

    public void writeDiceEyes()
    {
        foreach (var dice in diceCup)
        {
            Console.Write($"[{dice.GetDice()}] ");
        }
    }
    
}