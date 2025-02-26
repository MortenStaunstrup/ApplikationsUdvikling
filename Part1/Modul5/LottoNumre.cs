namespace Modul5;

public class LottoNumre
{
    Random random = new Random();
    List<int> numbers = new List<int>();
    
    public LottoNumre(int amount = 3)
    {
        if (amount > 100)
        {
            Console.WriteLine("Invalid amount.\nValue set to 100");
            amount = 100;
        }
        if (amount < 0)
        {
            Console.WriteLine("Invalid amount.\nValue set to 3");
            amount = 3;
        }
        
        for (int i = 0; i < amount; i++)
        {
            int value = random.Next(1, 101);
            while (numbers.Contains(value))
            {
                value = random.Next(1, 101);
            }
            
            numbers.Add(value);
        }
    }

    public void skriv()
    {
        Console.WriteLine($"Der er: {numbers.Count} numre tilbage");
    }

    public void træk()
    {
        if (numbers.Count == 0)
            Console.WriteLine("Der er ikke flere numre tilbage");
        else
        {
            int i = random.Next(0, numbers.Count - 1);
            Console.WriteLine($"Du trak: {numbers[i]}");
            numbers.RemoveAt(i);
        }
    }
}