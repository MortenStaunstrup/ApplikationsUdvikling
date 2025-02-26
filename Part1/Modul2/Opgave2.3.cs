namespace ConsoleApp1;

public class Opgave2_3
{
    public static void Cents(int amount, bool cent5 = false)
    {
        if (amount < 8)
        {
            Console.WriteLine("Amount has to be equal to or over 8");
        }
        else
       
        if (cent5)
        {
            Console.WriteLine($"You can use {amount / 5} 5 cents with {amount % 5} remaining");
        }
        else
        {
            Console.WriteLine($"You can use {amount / 8} 8 cents with {amount % 8} remaining");
        }
    }
}