namespace Modul7CronOpg;

public class UdvidetRandom : Random
{
    public bool NextBool()
    {
        Random rnd = new Random();
        int o = rnd.Next(2);
        
        if (o == 0)
            return true;
        return false;
    }
}