namespace Modul7CronOpg;

public class Person
{
    public string? fornavn { get; set; }
    public string? efternavn { get; set; }
    
    
    public string FuldtNavn()
    {
        return fornavn + " " + efternavn;
    }
}