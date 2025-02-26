namespace Modul1;

public class Opgave5_2
{
    public static void Run()
    {
        
        int num1 = 0;
        bool pass1 = false;

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
        
        int num2 = 0;
        bool pass2 = false;

        while (!pass2)
        {
            try
            {
                Console.Write("Please enter another number: ");
                num2 = int.Parse(Console.ReadLine());
                pass2 = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        string op;
        bool pass3 = false;

        while (!pass3)
        {
            Console.Write("Please enter an operator (+, -, *, /): ");
            op = Console.ReadLine();
            
            if (op == "+")
            {
                Console.Write(num1 + num2);
                pass3 = true;
            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
                pass3 = true;
            } else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
                pass3 = true;
            } else if (op == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by 0");
                    pass3 = true;
                    
                }
                else
                {
                    Console.WriteLine(num1 / num2);
                    pass3 = true;
                }
            }
            
        }
        
        
    }
}