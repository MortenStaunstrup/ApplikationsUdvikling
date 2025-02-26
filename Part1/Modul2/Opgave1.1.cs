namespace ConsoleApp1;

public class Opgave1_1
{
    public static void FrequencyOfNum(int[] array, int num)
    {
        int result = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num)
            {
                result++;
            }
        }

        Console.WriteLine($"There are {result} amount of {num} in the array.");
        
    }
}