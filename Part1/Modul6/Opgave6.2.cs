namespace Modul6;

public class Opgave6_2
{
    public static void run()
    {
        Person[] personer = new Person[4];
        personer[0] = new Person("Gert", new System.DateOnly(2002, 2, 12), 'M', 210, 140, "1203020000");
        personer[1] = new Person("Peter", new System.DateOnly(1940, 5, 21), 'M', 150, 50, "2301093421");
        personer[2] = new Person("Cirkeline", new System.DateOnly(), 'K', 170, 90, "9381729361");
        personer[3] = new Person("På grænse til teenager", new System.DateOnly(2007, 2, 16), 'M', 170, 90, "8374192836");

        for (int i = 0; i < personer.Length; i++)
        {
            personer[i].GetPerson();
        }
        
        Console.WriteLine(personer[0].ErTeenager());

    }
}