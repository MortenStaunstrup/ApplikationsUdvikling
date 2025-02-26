namespace Modul1;

public class Opgave4_2
{
    public static void Run()
    {
        int number = 0;
        bool pass1 = false;

        try
        {
            Console.Write("Please enter a number: ");
            number = int.Parse(Console.ReadLine());

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        int sum = 0;
        
        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }
}