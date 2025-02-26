namespace Modul7OpgArv;

public class FastAnsat : Ansat
{
    public double månedsløn {get; set;}
    

    public override double BruttoLøn()
    {
        return månedsløn;
    }

    public override double BetaltSkat()
    {
        return (månedsløn - fradrag) * trækprocent;
    }

    public override double NettoLøn()
    {
        double løn = månedsløn - BetaltSkat();
        if (frokostordning)
            løn -= 350;
        if (gavekassen)
            løn -= 30;
        
        return løn;
    }

    public override void Lønseddel()
    {
        base.Lønseddel();
        Console.WriteLine("Type: Fastansat");
        Console.WriteLine($"Månedsløn: {månedsløn.ToString("C")}");
        Console.WriteLine($"Fradrag: {fradrag.ToString("C")}");
        Console.Write($"Skat: {trækprocent * 100}% af {månedsløn - fradrag:C}     ");
        Console.WriteLine($"-{BetaltSkat().ToString("C")}");
        if (frokostordning)
            Console.WriteLine($"Frokostordning: -{350.ToString("C")}");
        if (gavekassen)
            Console.WriteLine($"Gavekassen: -{30.ToString("C")}");
        Console.WriteLine($"Netto: {NettoLøn().ToString("C")}");
    }
    
}