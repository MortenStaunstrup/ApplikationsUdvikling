namespace ConsoleApp1;

public class Opgave2_2
{
    public static bool IsPalindromeA(string s)
    {
        bool isPalindrome = true;
        
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != charArray[i])
            {
                isPalindrome = false;
                break;
            }
        }
        
        Console.WriteLine(isPalindrome);
        return isPalindrome;
    }

    public static bool IsPalindromeB(string s)
    {
        bool isPalindrome = true;

        int i = 0;
        int j = s.Length - 1;

        while (j > i)
        {
            if (s[i] == ' ' && s[j] == ' ')
            {
                i++;
                j--;
            } else if (s[i] == ' ')
            {
                i++;
            } else if (s[j] == ' ')
            {
                j--;
            }

            if (s[i] != s[j])
            {
                isPalindrome = false;
                break;
            }
            
            j--;
            i++;
            
        }
        
        Console.WriteLine(isPalindrome);
        return isPalindrome;

    }
}