namespace Modul4;

public class Opgave4_2
{
    public static void run()
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Write a grade or 'stop' when finished: ");
            string input = Console.ReadLine();
            if (input == "stop")
            {
                break;
            }
            else if (int.TryParse(input, out int number))
            {
                if (number == -3 || number == 0 || number == 2 || number == 4 || number == 7 || number == 10 ||
                    number == 12)
                    numbers.Add(number);
                else
                {
                    Console.WriteLine("Invalid grade");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }

        AverageAndFrequency(numbers);
        
        static void AverageAndFrequency(List<int> numbers)
        {
            int g3 = 0;
            int g00 = 0;
            int g02 = 0;
            int g4 = 0;
            int g7 = 0;
            int g10 = 0;
            int g12 = 0;

            double sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == -3)
                {
                    g3++;
                    sum += numbers[i];
                }
                else if (numbers[i] == 0)
                {
                    g00++;
                    sum += numbers[i];
                }
                else if (numbers[i] == 2)
                {
                    g02++;
                    sum += numbers[i];
                }
                else if (numbers[i] == 4)
                {
                    g4++;
                    sum += numbers[i];
                }
                else if (numbers[i] == 7)
                {
                    g7++;
                    sum += numbers[i];
                }
                else if (numbers[i] == 10)
                {
                    g10++;
                    sum += numbers[i];
                }
                else if (numbers[i] == 12)
                {
                    g12++;
                    sum += numbers[i];
                }
            }

            Console.WriteLine(
                $"Frequency of grades:\n-3: {g3}\n00: {g00}\n02: {g02}\n4: {g4}\n7: {g7}\n10: {g10}\n12: {g12}");
            Console.WriteLine($"Average: {sum / numbers.Count}");
        }
    }
}