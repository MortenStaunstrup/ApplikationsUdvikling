namespace Modul3;

public class Opgave3_1
{
    public static void run()
    {
        bool pass1 = false;
        int howMany = 0;

        while (!pass1)
        {
            try
            {
                Console.Write("Please enter how many numbers do you want to calculate the average, variance and deviation?: ");
                howMany = int.Parse(Console.ReadLine());
                pass1 = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        double[] numbers = new double[howMany];
        int currentNumber = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            bool pass = false;
            while (!pass)
            {
                try
                {
                    Console.Write($"Please enter number {currentNumber}: ");
                    numbers[i] = double.Parse(Console.ReadLine());
                    pass = true;
                    currentNumber++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
        
            }
    
        }

        Console.WriteLine($"The average of the numbers is: {Average(numbers)}");
        Console.WriteLine($"The variance of the numbers is: {Variance(numbers)}");
        Console.WriteLine($"The standard deviation of the numbers is: {Deviation(numbers)}");
        
        static double Average(double[] array)
        {
            double sum = 0;
            int i = 0;
            
            while (i < array.Length)
            {
                sum += array[i];
                i++;
            }
            
            return sum / array.Length;
        }

        static double Variance(double[] array)
        {
            double average = Average(array);
            double sum = 0;
            // Varians er tallet minus gennemsnittet i anden
            foreach (var num in array)
            {
                sum += Math.Pow(num - average, 2);
            }
            
            return sum / array.Length;
        }

        static double Deviation(double[] array)
        {
            // Skal være kvadratroden af variansen
            return Math.Sqrt(Variance(array));
        }
    }
    
    
}