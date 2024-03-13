using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 13, 21, 3, 4, 15, 6, 7, 8, 92, 10, 11, };

        bubblesort(array);     //applies the sorting function
        for (int i = 0; i < array.Length; i++)
        { Console.WriteLine(array[i]); }           //outputs
    
    }
    private static int[] bubblesort(int[] sorted)
    {
        int temp;
        for (int j = 0; j <= sorted.Length - 2; j++)
        {
            for (int i = 0; i <= sorted.Length - 2; i++)
            {
                if (sorted[i] > sorted[i + 1])  //comparison of pair
                {
                    temp = sorted[i + 1];   //if swapping is required, one value is stored so that the other value can overwrite it
                    sorted[i + 1] = sorted[i];    //swap
                    sorted[i] = temp;       //value that was overwritten is now stored in the array again
                }
            }
        }
        return sorted;
    }
}