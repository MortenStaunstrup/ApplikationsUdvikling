namespace Modul6;

public class Person
{
    private string navn;
    private DateOnly fødselsdag;
    private char køn;
    private int højde;
    private int vægt;
    private string CPR;

    public Person(string navn, DateOnly fødselsdag, char køn, int højde, int vægt, string CPR)
    {
        this.navn = navn;
        this.fødselsdag = fødselsdag;
        this.køn = køn;
        this.højde = højde;
        this.vægt = vægt;
        if (CPR.Length > 10 || CPR.Length < 10)
        {
            Console.WriteLine($"{CPR} er et forkert CPR-nummer. Sat til standard værdi");
            this.CPR = "0000000000";
        }
        else
        {
            this.CPR = CPR;
        }
    }

    public void GetPerson()
    {
        Console.WriteLine($"Navn: {navn}");
        Console.WriteLine($"Fødselsdag: {fødselsdag}");
        Console.WriteLine($"Køn: {køn}");
        Console.WriteLine($"Højde: {højde}");
        Console.WriteLine($"Vægt: {vægt}");
        Console.Write("CPR: ");
        for (int i = 0; i < CPR.Length - 4; i++)
        {
            Console.Write(CPR[i]);
        }
        Console.Write("-****\n");
        Console.WriteLine();
    }

    public double GetBMI()
    {
        return vægt / Math.Pow(højde, 2);
    }

    public bool ErTeenager()
    {
        // Nuværende år minus fødselsår
        int alder = DateTime.Now.Year - fødselsdag.Year;
        // Check om de har haft fødselsdag i år, hvis ikke, træk 1 år fra alder
        if (DateTime.Now.DayOfYear < fødselsdag.DayOfYear)
            alder--;
        
        if (alder <= 18)
            return false;
        return true;

    }
    
}