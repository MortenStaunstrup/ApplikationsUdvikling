namespace ConsoleApp1;

public class Opgave1_6
{
    public static void IsSortedAsc(int[] array)
    {
        bool isSorted = true;
        
        for (int i = 1; i < array.Length; i++)
        {
            if(array[i - 1] > array[i])
                isSorted = false;
        }
        
        Console.WriteLine(isSorted);
    }
}