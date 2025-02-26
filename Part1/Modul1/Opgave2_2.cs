namespace Modul1;

public class Opgave2_2
{
    public static void Run()
    {
        int number = 0;
        bool pass1 = false;

        try
        {
            Console.Write("Please enter a number: ");
            number = int.Parse(Console.ReadLine());
            pass1 = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        for (int i = number; i >= 1; i++)
        {
            Console.WriteLine(i);
        }
    }
}