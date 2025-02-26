namespace Modul4;

public class Opgave4_1
{

    public static void run()
    {
        
        bool stopped = false;
        List<double> numbers = new List<double>();

        while (!stopped)
        {
            Console.Write("Write a number or stop when finished: ");
            string input = Console.ReadLine();
            if (input == "stop")
            {
                stopped = true;
            } else if (double.TryParse(input, out double number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }



        Console.WriteLine($"The average of the numbers is: {Average(numbers)}");
        Console.WriteLine($"The variance of the numbers is: {Variance(numbers)}");
        Console.WriteLine($"The standard deviation of the numbers is: {Deviation(numbers)}");
        
        static double Average(List<double> numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum / numbers.Count;
        }

        static double Variance(List<double> numbers)
        {
            double average = Average(numbers);
            double sum = 0;
            // Varians er tallet minus gennemsnittet i anden
            foreach (var num in numbers)
            {
                sum += Math.Pow((num - average), 2);
            }
            
            return sum / numbers.Count;
        }

        static double Deviation(List<double> numbers)
        {
            // Skal være kvadratroden af variansen
            return Math.Sqrt(Variance(numbers));
        }
    }
}