namespace ConsoleApp1;

public class Opgave2_1
{
    public static void Cents(int amount)
    {
        if (amount < 8)
            Console.WriteLine("Amount is less than 8");
        else
        {
            if(amount % 5 == 0 && amount % 3 == 0)
                Console.WriteLine($"You can use {amount / 5} 5 cents OR {amount / 3} 3 cents.");
            else if (amount % 5 == 0)
                Console.WriteLine($"You can use {amount / 5} 5 cents");
            else if (amount % 3 == 0)
                Console.WriteLine($"You can use {amount / 3} 3 cents");
            else
            {
                int amountOfCentsLeft8 = amount % 5;

                if (amountOfCentsLeft8 == 3)
                {
                    Console.WriteLine($"You can use {amount / 5} 5 cents and {(amount % 5) / 3} 3 cents.");
                }
                else if (amountOfCentsLeft8 > 3)
                {
                    Console.WriteLine($"You can use {amount / 5} 5 cents and {(amount % 5) / 3} 3 cents. With {(amount % 5) % 3} cents remaining.");
                }
            }
        }
    }
}