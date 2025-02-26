using Modul7OpgArv;

FastAnsat Morten = new FastAnsat 
    {navn = "Morten", adresse = "Vestervang", email = "mort490fgromling@gmail.com", 
        fradrag = 3000, trækprocent = 0.50, frokostordning = true, gavekassen = true, månedsløn = 10000};
DeltidAnsat Gert = new DeltidAnsat
    {navn = "Gert", adresse = "Dumvej", email = "Dum@dum.com", 
        fradrag = 5000, trækprocent = 0.50, frokostordning = true, gavekassen = false, timeløn = 1000, timer = 10};
Konsulent Ygir = new Konsulent
    {navn = "Ygir", adresse = "Odinsgård", email = "Odj@dfjief",
        fradrag = 2000, trækprocent = 0.36, frokostordning = false, gavekassen = true, honorar = 50000, månederAnsat = 4};

List<Ansat> MG = new List<Ansat>();
MG.Add(Morten);
MG.Add(Gert);
MG.Add(Ygir);



double SumBruttoLøn(List<Ansat> Ansatte)
{
    double sum = 0;

    foreach (var ansat in Ansatte)
    {
        sum += ansat.BruttoLøn();
    }
    return sum;
}

double SumBetaltSkat(List<Ansat> Ansatte)
{
    double sum = 0;

    foreach (var ansat in Ansatte)
    {
        sum += ansat.BetaltSkat();
    }
    
    return sum;
}

void Lønseddler(List<Ansat> Ansatte)
{
    foreach (var ansat in Ansatte)
    {
        ansat.Lønseddel();
    }
}
