namespace ConsoleApp1;

public class Opgave1_5
{
    public static void HowManyVowels(string s)
    {
        int sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'A' || s[i] == 'a' || s[i] == 'E' || s[i] == 'e' || s[i] == 'I' || s[i] == 'i' || s[i] == 'O' ||
                s[i] == 'o' || s[i] == 'U' || s[i] == 'u')
                sum += 1;
        }

        Console.WriteLine($"{sum}");
    }
}