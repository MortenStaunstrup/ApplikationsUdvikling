namespace ConsoleApp1;

public class Opgave1_2
{
    public static void SumOfEvenNums(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                sum += array[i];
            }
        }
        
        Console.WriteLine($"The sum of the even numbers is {sum}");
    }
}