namespace Modul4;

public class SamlingerSimpel
{
    public static void List()
    {
        List<int> list = new List<int>() { 8, 9, 10 };
        foreach (var num in list)
        {
            Console.Write($"{num} ");
        }
    }

    public static void Stack()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(8);
        stack.Push(9);
        stack.Push(10);

        foreach (var num in stack)
        {
            Console.Write($"{num} ");
            
        }
    }

    public static void Dictionary()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "One");
        dictionary.Add(2, "Two");
        dictionary.Add(3, "Three");
        
        Console.WriteLine(dictionary[1]);
    }
}