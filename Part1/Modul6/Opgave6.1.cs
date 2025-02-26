namespace Modul6;

public class Opgave6_1
{
    public void run()
    {
        bool play = false;
        int round = 1;
        Yatzy yatz = new Yatzy();
        
        Console.Write("Welcome to Yatzy, ready to play? (y/n): ");
        char input = Console.ReadLine().ToLower()[0];

        if (input == 'y')
            play = true;
        

        
        while (play)
        {
            Console.WriteLine($"Round {round}, roll the dice");
            yatz.KastOgVisTerninger();
            Console.Write("How many dice do you want to keep?: ");
            int amountOfDices = int.Parse(Console.ReadLine());

            if (amountOfDices > 0 || amountOfDices < 6)
            {
                List<int> dices = new List<int>();
                for (int i = 0; i < amountOfDices; i++)
                {
                    Console.Write($"Which dice do you want to keep?: ");
                    dices.Add(int.Parse(Console.ReadLine()));
                }
                
                yatz.BeholdTerninger(amountOfDices, dices);
            }


        }
        
        Console.WriteLine("Ok bye");
        Console.ReadLine();

    }
}