namespace _01_Age;

public class Correction
{
    static public void MainCorrection(String[] args) 
    { 
        Console.WriteLine("Quel age as-tu ?");
        String entry = Console.ReadLine();
        int age = int.Parse(entry);
        if (age > 18)
        {
            Console.WriteLine("Tu est Majeur");
        }
        else if (age == 18)
        {
            Console.WriteLine("Bravo tu viens d'etre majeur !");
        }
        else
        {
            Console.WriteLine("Tu est encore mineur !");
        }
    }
}