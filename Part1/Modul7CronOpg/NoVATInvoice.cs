namespace Modul7CronOpg;

public class NoVATInvoice : Invoice
{
    public override decimal CalculateTotal()
    {
        return Amount;
    }
}