package moreonarrays;

import java.util.Scanner;

public class MoreOnArrays {

    static Scanner input = new Scanner(System.in);

    public static void main(String[] args)
    {
        System.out.println("Input 20 Numbers");

        int[] numbers = new int[20];

        for (int i = 0; i < 20; i++)
        {
            numbers[i] = input.nextInt();
        }

        System.out.println();
    }
    
    private static void displayNums(int[] array, int size)
    {
        for (int i = 0; i < size - 1; i++)
        {
            System.out.println(i);
        }
    }

    private static int countEven(int[] array, int size)
    {
        int count = 0;

        for (int i = 0; i < size - 1; i++)
        {
            if (array[i] % 2 == 0)
            {
                count += 1;
            }
        }

        return count;
    }

    private static int countOdd(int[] array, int size)
    {
        int count = 0;

        for (int i = 0; i < size - 1; i++)
        {
            if (array[i] % 2 != 0)
            {
                count += 1;
            }
        }

        return count;
    }

    private static int avgEven(int[] array, int size)
    {
        int avg = 0;
        int count = 0;

        for (int i = 0; i < size - 1; i++)
        {
            if (array[i] % 2 == 0)
            {
                avg += array[i];
                count += 1;
            }
        }
        
        return avg / count;
    }

    private static int avgOdd(int[] array, int size)
    {
        int avg = 0;
        int count = 0;

        for (int i = 0; i < size - 1; i++)
        {
            if (array[i] % 2 != 0)
            {
                avg += array[i];
                count += 1;
            }
        }
        
        return avg / count;
    }

    private static int largest(int[] array, int size)
    {
        int largest = array[0];

        for (int i = 1; i < size - 1; i++)
        {
            if (array[i] > largest)
            {
                largest = array[i];
            }
        }

        return largest;
    }

    private static int smallest(int[] array, int size)
    {
        int smallest = array[0];

        for (int i = 1; i < size - 1; i++)
        {
            if (array[i] < smallest)
            {
                smallest = array[i];
            }
        }

        return smallest;
    }
}