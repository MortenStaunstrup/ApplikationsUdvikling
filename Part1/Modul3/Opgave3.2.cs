namespace Modul3;

public class Opgave3_2
{

    public static void run()
    {
        
        int n = 0;
        bool passed = false;
        
        while (!passed)
        {
            try
            {
                Console.Write("How many grades do you want to enter?: ");
                n = int.Parse(Console.ReadLine());
                passed = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        int[] grades = new int[n];
        int currentNumber = 1;
        
        for (int i = 0; i < grades.Length; i++)
        {
            bool correctGrade = false;
        
            while (!correctGrade)
            {
                try
                {
                    Console.Write($"Enter grade {currentNumber}: ");
                    int tryNumber = int.Parse(Console.ReadLine());
                    if  (tryNumber == -3 || tryNumber == 0 || tryNumber == 2 || tryNumber == 4 || tryNumber == 7 ||
                        tryNumber == 10 || tryNumber == 12)
                    {
                        grades[i] = tryNumber;
                        correctGrade = true;
                        currentNumber++;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid grade!!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        
        AverageAndFrequency(grades);
        
        
        static void AverageAndFrequency(int[] array)
        {
            int g3 = 0;
            int g00 = 0;
            int g02 = 0;
            int g4 = 0;
            int g7 = 0;
            int g10 = 0;
            int g12 = 0;

            double sum = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == -3)
                {
                    g3++;
                    sum += array[i];
                } else if (array[i] == 0)
                {
                    g00++;
                    sum += array[i];
                } else if (array[i] == 2)
                {
                    g02++;
                    sum += array[i];
                } else if (array[i] == 4)
                {
                    g4++;
                    sum += array[i];
                } else if (array[i] == 7)
                {
                    g7++;
                    sum += array[i];
                } else if (array[i] == 10)
                {
                    g10++;
                    sum += array[i];
                } else if (array[i] == 12)
                {
                    g12++;
                    sum += array[i];
                }
            }
            
            Console.WriteLine($"Frequency of grades:\n-3: {g3}\n00: {g00}\n02: {g02}\n4: {g4}\n7: {g7}\n10: {g10}\n12: {g12}");
            Console.WriteLine($"Average: {sum / array.Length}");
        
        }
    }
}