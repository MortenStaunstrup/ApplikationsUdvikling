namespace Modul7CronOpg;

public class StandardInvoice : Invoice
{
    public override decimal CalculateTotal()
    {
        return Amount * 1.25m;
    }
}