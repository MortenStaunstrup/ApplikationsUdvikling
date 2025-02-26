namespace Modul7CronOpg;

public abstract class Invoice
{
    private decimal amount;

    public decimal Amount
    {
        get { return amount; }
        set { amount = value > 0 ? value : 0; }
    }
    public string Description { get; set; }
    
    public abstract decimal CalculateTotal();

    public void Display()
    {
        Console.WriteLine($"Amount: {Amount}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Total (with VAT): {CalculateTotal()}");
    }
}