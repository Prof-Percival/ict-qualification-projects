package c9e2_smalllndex;

/**
 *
 * @author Christoph
 */

import java.util.Scanner;

public class C9E2_Smalllndex {

    static Scanner input = new Scanner(System.in);
    
    public static void main(String[] args) {
        
        int[] data = {3, 5, 2, 6, 10, 9, 7, 11, 1, 8};
        
        int smallIndex = C9E2_Smalllndex.smallestIndex(data, data.length);
        
        System.out.println("Index of The Smallest Element in The Array: " + smallIndex);
        
    }
    
    public static int smallestIndex(int[] smallIndex, int size)
    {
        int index = 0;
        
        for (int i = 0; i < size; i++)
        {
            if (i < size - 1)
            {
                if (smallIndex[i] < smallIndex[i + 1]){
                    index = i;
                }
                else
                {
                    index = i + 1;
                }
            }
        }
        
        return index;
    }
}