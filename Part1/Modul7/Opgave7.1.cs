namespace Modul7;

public class Opgave7_1
{
    public void Run()
    {
        DiceCup cup = new DiceCup(2, 4, 100);
        
        cup.Roll();
        
        cup.writeDiceEyes();
        
    }
}