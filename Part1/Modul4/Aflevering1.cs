namespace Modul4;

public class Aflevering1
{
    public void Run()
    {
        
        List<int> numbers = new List<int>();
        bool passed = false;
        int currentNum = 1;
        
        while (!passed)
        {
            Console.Write($"Enter number {currentNum} or stop when finished: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "stop")
            {
                passed = true;
            } else if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
                currentNum++;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }
        
        Console.WriteLine($"\nAmount of numbers entered: {numbers.Count}");
        Console.WriteLine($"Sum of all positive numbers: {SumPositiveNums(numbers)}");
        Console.WriteLine($"Biggest value: {BiggsetValue(numbers)} Smallest value: {SmallestValue(numbers)}");
        
    }

    int SumPositiveNums(List<int> numbers)
    {
        int sum = 0;

        foreach (var num in numbers)
        {
            if (num > 0)
                sum += num;
        }
        return sum;
    }

    int BiggsetValue(List<int> numbers)
    {
        int currentMax = int.MinValue;
        if (numbers.Count == 0)
            return 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            if(numbers[i] > currentMax)
                currentMax = numbers[i];
        }
        
        return currentMax;
    }

    int SmallestValue(List<int> numbers)
    {
        int currentMin = int.MaxValue;
        if (numbers.Count == 0)
            return 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            if(numbers[i] < currentMin)
                currentMin = numbers[i];
        }
        return currentMin;
    }
    
}