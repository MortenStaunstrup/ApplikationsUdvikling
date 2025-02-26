namespace Modul7OpgArv;

public class Konsulent : Ansat
{
    public double honorar {get; set;}
    public int månederAnsat {get; set;}
    
    
    public override double BruttoLøn()
    {
        return honorar / månederAnsat;
    }

    public override double BetaltSkat()
    {
        return (honorar / månederAnsat - fradrag) * trækprocent;
    }

    public override double NettoLøn()
    { 
        return BruttoLøn() - BetaltSkat();
    }

    public override void Lønseddel()
    {
        base.Lønseddel();
        Console.WriteLine("Type: Konsulent");
        Console.WriteLine($"Honorar: {honorar:C} for {månederAnsat} måneder");
        Console.WriteLine($"Månedsløn: {BruttoLøn().ToString("C")}");
        Console.WriteLine($"Fradrag: {fradrag.ToString("C")}");
        Console.Write($"Skat: {trækprocent * 100}% af {BruttoLøn() - fradrag:C}     ");
        Console.WriteLine($"-{BetaltSkat().ToString("C")}");
        Console.WriteLine($"Netto: {NettoLøn().ToString("C")}");
    }
}