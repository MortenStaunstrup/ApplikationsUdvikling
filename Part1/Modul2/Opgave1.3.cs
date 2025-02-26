namespace ConsoleApp1;

public class Opgave1_3
{
    public static void Roots(int a, int b, int c)
    {
        int d = b * 2 - 4 * a * c;
        
        if (d > 0)
            Console.WriteLine("Funktionen har 2 rødder");
        else if (d == 0)
            Console.WriteLine("Funktionen har 1 rod");
        else
            Console.WriteLine("Funktionen har 0 rødder");
    }
}