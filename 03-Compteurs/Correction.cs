namespace _03_Compteurs;

public class Correction
{
    public static int correctionCountNbVentesReussites(bool[] tableauxVentes) {
        int result = 0;
        foreach (bool vente in tableauxVentes)
        {
            if (vente) {
                result++;
            }
        }
        return result;
    }
    
    public static int correctionCountNbChiffreAffaireSupperieurSmic(int[] tableauxChiffresAffaires)
    {
        int result = 0;
        foreach (int chiffreAffaire in tableauxChiffresAffaires)
        {
            if (chiffreAffaire >= 1200) {
                result++;
            }
        }
        return result;
    }
    
    public static int correctionCountNbMercdesAvecMajusculeAleatoire(String[] tableauxMarquesVoituresDuParc)
    {
        int result = 0;
        foreach (String marque in tableauxMarquesVoituresDuParc)
        {
            String realMarque = marque.ToLower();
            if (realMarque == "mercedes")
            {
                result++;
            }
        }
        return result;
    }
}