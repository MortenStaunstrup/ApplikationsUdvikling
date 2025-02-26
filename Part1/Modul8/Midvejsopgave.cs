namespace Modul8;

public class Midvejsopgave
{
    public void run()
    {
        Item ting1 = new Item{Name = "Olie", Color = "White", Price = 10.99, Stock = 100};
        Item ting2 = new Item{Name = "WD40", Color = "Blue", Price = 29.99, Stock = 231};
        Item ting3 = new Item{Name = "Cykel", Color = "Black", Price = 3000, Stock = 0};
        Item ting4 = new Item{Name = "Coca-Cola", Color = "Red", Price = 1.29, Stock = 1200};
        Item ting5 = new Item{Name = "Dukker", Color = "White", Price = 59.99, Stock = 210};
        
        List<Item> tings = new List<Item>();
        
        tings.Add(ting1);
        tings.Add(ting2);
        tings.Add(ting3);
        tings.Add(ting4);
        tings.Add(ting5);

        foreach (var it in tings)
        {
            Console.WriteLine(it.Name);
            Console.WriteLine(it.Price.ToString("C"));
        }
        Console.WriteLine();

        List<Item> newItems = ItemsInStock(tings);

        foreach (var ting in newItems)
        {
            Console.WriteLine(ting.Name);
            Console.WriteLine(ting.Price.ToString("C"));
        }
        Console.WriteLine();
        
        List<Item> itemsWiColor = ItemsWithColor(tings, new []{"White"});

        foreach (var item in itemsWiColor)
        {
            Console.WriteLine(item.Name);
            Console.WriteLine(item.Price.ToString("C"));
            Console.WriteLine(item.Color);
        }
        Console.WriteLine();
        

    }

    public List<Item> ItemsInStock(List<Item> items)
    {
        List<Item> result = new List<Item>();

        foreach (var ting in items)
        {
            if (ting.Stock > 0)
                result.Add(ting);
        }
        return result;
    }

    public List<Item> ItemsWithColor(List<Item> items, string[] colors)
    {
        List<Item> result = new List<Item>();

        foreach (var item in items)
        {
            for (int i = 0; i < colors.Length; i++)
            {
                if (item.Color == colors[i])
                    result.Add(item);
                    
            }
        }
        
        return result;
    }
    
}


public class Item
{
    public string Name { get; set; }
    public double Price { get; set;}
    public int Stock { get; set; }
    public string Color { get; set; }
}



