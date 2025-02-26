namespace Modul1;

public class Opgave3_2
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

        for (int i = 1; i <= number ; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}