namespace Modul7OpgArv;

public abstract class Ansat
{
    public string? navn {get; set;}
    public string? adresse {get; set;}
    public string? email {get; set;}
    public double fradrag {get; set;}
    public double trækprocent {get; set;}
    public bool frokostordning {get; set;}
    public bool gavekassen {get; set;}
    

    public virtual double BruttoLøn()
    {
        return -1;
    }
    public virtual double BetaltSkat()
    {
        return -1;
    }
    public virtual double NettoLøn()
    {
        return -1;
    }
    
    
    public virtual void Lønseddel()
    {
        Console.WriteLine(navn);
        Console.WriteLine(adresse);
        Console.WriteLine($"Email: {email}");
    }
    
}