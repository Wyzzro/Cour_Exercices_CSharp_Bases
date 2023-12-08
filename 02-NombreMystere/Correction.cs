namespace _02_NombreMystere;

public class Correction
{
    static public void MainCorrection(String[] args)
    {
        Random rnd = new Random();
        int nb_mystere = rnd.Next(1, 1000);
        int nb_user = 0;

        while (nb_user != nb_mystere)
        {
            Console.WriteLine("Donnez un nombre !");
            String entry = Console.ReadLine();
            nb_user = int.Parse(entry);
            if (nb_user < nb_mystere)
            {
                Console.WriteLine("Le nombre mystere est plus grand !");
            } else if (nb_user > nb_mystere)
            {
                Console.WriteLine("Le nombre mystere est plus petit !");
            }
        }
        Console.WriteLine("Bravo, tu as trouvé le nombre mystère !");
        Console.WriteLine("Nombre mystère: " + nb_mystere);
    }
    
    static public void BonusCorrection(String[] args)
    {
        Random rnd = new Random();
        int nb_mystere = rnd.Next(1, 1000);
        int nb_user = 0;
        int nb_vies = 0;
        
        Console.WriteLine("Combien de vie voulez-vous ?");
        String entryVies = Console.ReadLine();
        nb_vies = int.Parse(entryVies);

        while (nb_user != nb_mystere && nb_vies > 0)
        {
            Console.WriteLine("Donnez un nombre !");
            String entry = Console.ReadLine();
            nb_user = int.Parse(entry);
            if (nb_user < nb_mystere)
            {
                nb_vies--;
                Console.WriteLine("Le nombre mystere est plus grand !");
            } else if (nb_user > nb_mystere)
            {
                nb_vies--;
                Console.WriteLine("Le nombre mystere est plus petit !");
            }
        }

        if (nb_vies > 0)
        {
            Console.WriteLine("Bravo, tu as trouvé le nombre mystère !");
            Console.WriteLine("Nombre mystère: " + nb_mystere);
        }
        else
        {
            Console.WriteLine("Perdu, tu n'as plus de vie !");
        }
    }
}