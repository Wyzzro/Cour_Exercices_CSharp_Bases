public class Program
{
    /*
       Cette fonction prend en paramètre un tableau d'int désordonné. Vous devez retourner un tableau contenant tous les
       chiffres de celui passer en paramètre, mais cette fois si tous les chiffres doivent être dans l'ordre descendant
       (le plus gros nombre en 1er et le plus petit nombre en dernier).
    */
    public static int[] reorderDesc(int[] disorganizeArray)
    {
     return new int[1]; // À supprimer quand vous avez codé votre fonction !
    }
    
    // Le but est le même que la fonction précédente sauf qu'elle est faisable en seulement 3, également en une seul si vous voulez pousser le vice !
    public static int[] reorderDescFlemVersion(int[] disorganizeArray)
    {
     return new int[1]; // À supprimer quand vous avez codé votre fonction !
    }
    
    /*
    Cette fonction prend en paramètre le tableau d'int que vous avez réorganisé dans l'ordre descendant. Vous devez
    retourner ce tableau avec cette fois-ci les valeurs dans l'ordre ascendant. (du plus petit au plus grand).
    Forcément, vous devez avoir réussi l'exercice précédent pour commencer celui-ci !
    */
    public static int[] inverseArray(int[] disorganizeArray)
    {
     return new int[1]; // À supprimer quand vous avez codé votre fonction !
    }

    // Le but est le même que la fonction précédente sauf qu'elle est faisable en seulement 3 ! 
    public static int[] inverseArrayFlemVersion(int[] disorganizeArray)
    {
     return new int[1]; // À supprimer quand vous avez codé votre fonction !
    }
    
     /*
     Ne modifiez rien au code suivant, c'est ce code qui permet de vous dire si vous avez réussi les exercices ou non !
    */
    static public void Main(String[] args)
    {
     int[] disorganizeArray = { 5, 1, 14, 16, 7, 3, 21, 19, 32, 29};
     int[] userArrayDesc = reorderDesc(disorganizeArray);
     int[] userArrayAsc = inverseArray(userArrayDesc);
     int[] userArrayDescFlemme = reorderDescFlemVersion(disorganizeArray);
     int[] userArrayAscFlemme = inverseArrayFlemVersion(userArrayDesc);
     
     int[] resultGoodDesc = { 32, 29, 21, 19, 16, 14, 7, 5, 3, 1};
     int[] resultGoodAsc = { 1, 3, 5, 7, 14, 16, 19, 21, 29, 32};

     if (ArrayEquals(userArrayDesc, resultGoodDesc))
     {
      Console.WriteLine("Bravos, tu as reussi l'exercice dans le sens descendant !");
     }
     else
     {
      Console.WriteLine("Mince, tu as une erreur sur le sens descendant, Réessaye !");
     }
     
     if (ArrayEquals(userArrayAsc, resultGoodAsc))
     {
      Console.WriteLine("Bravos, tu as reussi l'exercice reverse Array !");
     }
     else
     {
      Console.WriteLine("Mince, tu as une erreur sur le reverse Array, Réessaye !");
     }
     
     if (ArrayEquals(userArrayDescFlemme, resultGoodDesc))
     {
      Console.WriteLine("Bravos, tu as reussi l'exercice dans le sens descendant Flemme Version !");
     }
     else
     {
      Console.WriteLine("Mince, tu as une erreur sur le sens descendant Flemme Version, Réessaye !");
     }
     
     if (ArrayEquals(userArrayAscFlemme, resultGoodAsc))
     {
      Console.WriteLine("Bravos, tu as reussi l'exercice reverse Array Flemme Version !");
     }
     else
     {
      Console.WriteLine("Mince, tu as une erreur sur le reverse Array Flemme Version, Réessaye !");
     }
    }
    
    public static bool ArrayEquals(int[] resultTab, int[] goodResult) {
     if (resultTab.Length != goodResult.Length) {
       return false;
     }

     for (int i = 0; i < resultTab.Length; i++)
     {
      if (resultTab[i] != goodResult[i])
      {
       return false;
      }
     }

     return true;
    }
 
}