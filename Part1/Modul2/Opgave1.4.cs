namespace ConsoleApp1;

public class Opgave1_4
{
    public static void MinLengthString(string[] array, int length)
    {
        List<string> list = new List<string>();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= length)
            {
                list.Add(array[i]);
            }
        }

        Console.Write($"Strings with {length} length or more: ");
        list.ForEach(i => Console.Write("{0}, ",i));
    }
}