namespace Modul4;

public class BubbleSort
{
    public static void run()
    {
        int[] tal = { 5, 1, 4, 2, 8, 0, 2, 7, 6, 3, 9, 5, 8, 1, 4, 2, 7, 6, 3, 0 };
        BubbleSortArray(tal);
        Console.WriteLine("Sorteret rækkefølge:");
        foreach (var item in tal)
        {
            Console.Write(item + " ");
        }
        
    }

    private static void BubbleSortArray(int[] tal)
    {
        for (int k = 0; k < tal.Length - 1; k++)
        {
            for (int i = 0; i < tal.Length - k - 1; i++)
            {
                if (tal[i] > tal[i + 1])
                {
                    int temp = tal[i + 1];
                    tal[i + 1] = tal[i];
                    tal[i] = temp;
                }
            }
            
        }
    }
}