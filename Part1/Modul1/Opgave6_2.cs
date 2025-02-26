namespace Modul1;

public class Opgave6_2
{
    public static void RunA()
    {
        int min = 0;
        for (int i = 0; i < 10; i++)
        {
            string output = "";
            for (int j = 10; j - min > 0; j--) {
                output = output + "*";
            }
            Console.WriteLine(output);
            min++;
        }
    }

    public static void RunB()
    {
        int plus = 9;
        for (int i = 0; i < 10; i++)
        {
            string output = "";
            for (int j = 10; j - plus > 0; j--) {
                output = output + "*";
            }
            Console.WriteLine(output);
            plus--;
        }
    }
    
    public static void RunC()
    {
        int space = 9;
        int star = 1;
        for (int i = 0; i < 10; i++)
        {
            string output = "";
            
                for (int k = 0; k < space; k++)
                {
                    output = output + " ";
                }

                for (int l = 0; l < star; l++)
                {
                    output = output + "*";
                }

                space -= 1;
                star += 1;
            Console.WriteLine(output);
        }
    }
    
    public static void RunD()
    {
        int space = 0;
        int star = 10;
        for (int i = 0; i < 10; i++)
        {
            string output = "";
            
            for (int k = 0; k < space; k++)
            {
                output = output + " ";
            }

            for (int l = 0; l < star; l++)
            {
                output = output + "*";
            }

            space += 1;
            star -= 1;
            Console.WriteLine(output);
        }
    }
}