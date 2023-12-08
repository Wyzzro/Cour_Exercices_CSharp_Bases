namespace _04_Reorganisation;

public class Correction
{
    public static int[] correctionReorderDesc(int[] disorganizeArray)
    {
        int[] badArray = (int[]) disorganizeArray.Clone();
        int[] newArray = (int[]) disorganizeArray.Clone();
        int temp = 0;
        int indexNewArray = 0;
        while (indexNewArray < disorganizeArray.Length)
        {
            int tempIndex = 0;
            for (int i = 0; i < badArray.Length; i++) {
                if (i == 0 || badArray[i] > temp) {
                    temp = badArray[i];
                }
            }
            for (int i = 0; i < badArray.Length; i++) {
                if (badArray[i] == temp) {
                    tempIndex = i;
                }
            }
            newArray[indexNewArray] = temp;
            badArray[tempIndex] = 0;
            indexNewArray++;
        }
        return newArray;
    }
    
    public static int[] correctionReorderDescFlemVersion(int[] disorganizeArray)
    {
        return disorganizeArray.OrderByDescending(c => c).ToArray();;
    }
    
    public static int[] correctionInverseArray(int[] disorganizeArray)
    {
        int[] newArrayDesc = (int[]) disorganizeArray.Clone();
        int[] goodArray = (int[]) disorganizeArray.Clone();
        for (int i = 0; i < newArrayDesc.Length; i++) {
            if (i == 0) {
                goodArray[i] = newArrayDesc[newArrayDesc.Length - 1];
            }
            else {
                goodArray[i] = newArrayDesc[newArrayDesc.Length - i - 1];
            }
        }
        return goodArray;
    }
    
    public static int[] correctionInverseArrayFlemVersion(int[] disorganizeArray)
    {
        int[] goodArray = (int[]) disorganizeArray.Clone();
        Array.Reverse(goodArray);
        return goodArray;
    }
}