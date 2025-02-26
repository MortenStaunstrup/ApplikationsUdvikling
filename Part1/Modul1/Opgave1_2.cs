namespace Modul1;

public class Opgave1_2
{
    public static void Run()
    {

        bool pass1 = false;
        int num1 = 0;

        while (!pass1)
        {
            try
            {
                Console.Write("Please enter a number: ");
                num1 = int.Parse(Console.ReadLine());
                pass1 = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        
        bool pass2 = false;
        int num2 = 0;
        
        while (!pass2)
        {
            try
            {
                Console.Write("Please another a number: ");
                num2 = int.Parse(Console.ReadLine());
                pass2 = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
  
        
        int sum = num1 + num2;
        
        Console.Write($"The sum of the two numbers is {sum}");
    }
}