package gymnast;

import java.util.Scanner;

public class Gymnast {

    static Scanner input = new Scanner(System.in);

    public static void main(String[] args)
    {

        int[] mark = new int[5];

        for (int i = 1; i <= 5; i++)
        {
            System.out.print("Mark out of 5: Judge " + i + " >> ");
            mark[i - 1] = input.nextInt();
        }

        System.out.println("Highest Score: " + highest(mark));
        System.out.println("Average Score: " + average(mark));
    }
    
    private static int highest(int[] scores)
    {
        int highestScore = scores[0];
        int index = 0;

        for (int i = 1; i < 5; i++)
        {
            if (scores[i] > highestScore)
            {
                index = i;
                highestScore = scores[i];
            }
        }

        System.out.println("Index of Highest Score: " + index);
        System.out.println("Position of Highest Score: " + (index + 1));

        return highestScore;
    }

    private static int average(int[] scores)
    {
        int avg = 0;

        for (int i: scores)
        {
            avg += i;
        }

        return avg / 5;
    }
}