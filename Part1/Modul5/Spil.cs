namespace Modul5;

public class Spil
{
    private int TilfældigtTal;

    public void Start()
    {
        TilfældigtTal = GenererTilfældigtTal();
        int minimum = 1;
        int maximum = 100;
        int gætNr = 0;
        
        bool korrekt = false;
        
        Console.ForegroundColor = ConsoleColor.Green;
        
        while (!korrekt)
        {
            gætNr++;
            Console.WriteLine($"\nGæt nr: {gætNr}");
            korrekt = GivFeedback(HentTalFraBruger(minimum, maximum), TilfældigtTal, ref minimum, ref maximum);
        }
        
        Console.WriteLine($"\nKorrekt gættet! du gættede nummeret på {gætNr} forsøg");

    }

    private int GenererTilfældigtTal()
    {
        Random random = new Random();
        return random.Next(1, 101);
    }

    private int HentTalFraBruger(int minimum, int maximum)
    {
        Console.Write($"Hvad tror du tallet er? ({minimum} - {maximum}): ");
        bool passed = false;
        int gæt = 0;
        while (!passed)
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number > 100 || number < 1)
                {
                    Console.WriteLine("Tallet skal være mellem 1 og 100");
                }
                else
                {
                    gæt = number;
                    passed = true;
                }
            }
            else
            {
                Console.WriteLine("Du skal indtaste et tal");
            }
        }

        return gæt;
    }

    private bool GivFeedback(int gæt, int tallet, ref int min, ref int max)
    {
        if (gæt > tallet)
        {
            Console.WriteLine("\nTallet er mindre end gættet");
            max = gæt - 1;
            return false;
        }
        else if (gæt < tallet)
        {
            Console.WriteLine("\nTallet er større en gættet");
            min = gæt + 1;
            return false;
        }
        else
        {
            return true;
        }
        
    }
    
}