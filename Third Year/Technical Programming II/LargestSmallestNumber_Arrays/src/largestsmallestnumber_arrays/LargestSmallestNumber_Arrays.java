package largestsmallestnumber_arrays;

import java.util.Scanner;

public class LargestSmallestNumber_Arrays {

    static Scanner input = new Scanner(System.in);
    
    public static void main(String[] args)
    {
        int[] integers = new int[4];

        System.out.println("Input 4 Integers");

        for (int i = 0; i < 4; i++)
        {
            integers[i] = input.nextInt();
        }

        /*
        for (int i : integers)
        {
            System.out.printf("%d ",i);
        }
         */

        System.out.println("\nLargest Number: " + largestNumber(integers));

        System.out.println("Smallest Number: " + smallestNumber(integers));

        System.out.println();
        
    }
    
    private static int largestNumber(int[] numbers)
    {
        int largest = 0;

        for (int i : numbers)
        {
            if (i > largest)
            {
                largest = i;
            }
        }

        //System.out.println("Largest Number: " + largest);

        return largest;
    }

    private static int smallestNumber(int[] numbers)
    {
        int smallest = numbers[0];

        for (int i = 1; i < numbers.length - 1; i++)
        {
            if (numbers[i] < smallest)
            {
                smallest = numbers[i];
            }
        }

        //System.out.println("Smallest Number: " + smallest);
        
        return smallest;
    }
}