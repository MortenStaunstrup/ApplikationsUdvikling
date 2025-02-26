namespace Modul7OpgArv;

public class DeltidAnsat : Ansat
{
    public double timeløn {get; set;}
    public double timer {get; set;}
    

    public override double BruttoLøn()
    {
        return timeløn * timer;
    }
    
    public override double BetaltSkat()
    {
        return (timeløn * timer - fradrag) * trækprocent;
    }
    
    public override double NettoLøn()
    {
        double løn = BruttoLøn() - BetaltSkat();
        if (frokostordning)
            løn -= 350 * 0.70;
        if (gavekassen)
            løn -= 30;
        
        return løn;
    }
    
    public override void Lønseddel()
    {
        base.Lønseddel();
        Console.WriteLine("Type: Deltidsansat");
        Console.WriteLine($"{timer} timer af {timeløn.ToString("C")}     {BruttoLøn().ToString("C")}");
        Console.WriteLine($"Fradrag: {fradrag.ToString("C")}");
        Console.Write($"Skat: {trækprocent * 100}% af {BruttoLøn() - fradrag:C}     ");
        Console.WriteLine($"-{BetaltSkat().ToString("C")}");
        if (frokostordning)
            Console.WriteLine($"Frokostordning: -{350.ToString("C")}");
        if (gavekassen)
            Console.WriteLine($"Gavekassen: -{30.ToString("C")}");
        Console.WriteLine($"Netto: {NettoLøn().ToString("C")}");
    }
    
}