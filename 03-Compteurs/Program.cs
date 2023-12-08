public class Program
{
    /*
    Cette fonction prend en paramètre un tableau de boolean, ce tableau correspond à toutes les ventes faites, quand
    la valeur est à false la vente n'a pas été accomplie, quand il est à true la vente à réussie. Vous devez retourner
    le nombre de ventes réussites.
     */
    public static int countNbVentesReussites(bool[] tableauxVentes)
    {
     return 0; // À supprimer quand vous avez codé votre fonction !
    }

    /*
    Cette fonction prend en paramètre un tableau d'int, ce tableau contient tous les chiffres d'affaires de chaque mois
    sur 15 mois. Vous devez retourner le nombre de mois ou le chiffre d'affaires a été supérieur à 1200$.
     */
    public static int countNbChiffreAffaireSupperieurSmic(int[] tableauxChiffresAffaires)
    {
     return 0; // À supprimer quand vous avez codé votre fonction !
    }
    
    /*
     Cette fonction prend en paramètre un tableau de string qui comportera des marques de voitures. Vous devrez retourner le
     nombre de Mercedes. Cependant l'employer ayant rempli le tableau a fait n'importe quoi et à écrit Mercedes avec des majuscules 
     et des minuscules aléatoire à chaque fois. Vous devez faire en sorte de pouvoir compter le nombre de Mercedes peu importe les majuscules qu'elles contiennent !
     Indice: Il doit bien avoir un moyen de passer tous les caractères en minuscule ou en majuscule ?!
     */
    public static int countNbMercdesAvecMajusculeAleatoire(String[] tableauxMarquesVoituresDuParc)
    {
     return 0; // À supprimer quand vous avez codé votre fonction !
    }
    
    /*
     Ne modifiez rien au code suivant, c'est ce code qui permet de vous dire si vous avez réussi les exercices ou non !
    */
    static public void Main(String[] args)
    {
     bool[] ventesReussites = {true, false, false, false, true, false, true, true, true, true, true, false, true, true};
     int[] chiffreAffaireParMois = { 954, 1207, 1675, 1184, 2205, 994, 1352, 2099, 650, 842, 1200, 1198, 754, 854, 3298};
     String[] marqueVoituresDuParc = { "Peugeot", "Citroen", "Renault", "Mercedes", "Opel", "AuDi", "MerCeDeS", "bMw", "Fiat", "Ford", "mERceDeS", "mERCEDEs", "reNAULT", "BMW", "MeRCEdEs"};

     //Test exercice Nombre Ventes Réussites
     if (countNbVentesReussites(ventesReussites) == 9) {
      Console.WriteLine("Tu as reussi l'exercice sur le nombre de ventes reussites !");
     }
     else {
      Console.WriteLine("Ho ho erreur, tu n'as pas réussie l'exercice du nombre de ventes réussites ! Réessaye !");
     }

     //Test exercice Nombre Chiffre d'affaires supérieur a 1200
     if(countNbChiffreAffaireSupperieurSmic(chiffreAffaireParMois) == 7) {
      Console.WriteLine("Tu as reussi l'exercice sur le nombre de chiffre d'affaire superieur a 1200 !");
     }
     else {
      Console.WriteLine("Ho ho erreur, tu n'as pas réussie l'exercice du nombre de chiffre d'affaire superieur a 1200 ! Réessaye !");
     }
     
     //Test exercice Nombre MeRcEdEs dans le parc avec Majuscule aléatoire dans le tableau
     if(countNbMercdesAvecMajusculeAleatoire(marqueVoituresDuParc) == 5) {
      Console.WriteLine("Tu as reussi l'exercice sur le nombre de voitures MeRcEdEs dans le parc !");
     }
     else {
      Console.WriteLine("Ho ho erreur, tu n'as pas réussie l'exercice du nombre de voitures MeRcEdEs dans le parc ! Réessaye !");
     }
     
    }
}