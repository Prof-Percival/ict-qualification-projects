package divisibilitytest;

import java.util.Scanner;

public class DivisibilityTest {

    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);
        
        int sum, temp, number;
        
        System.out.print("Input A Positive Integer: ");
        number = input.nextInt();
        
        temp = number;
        
        sum = 0;
        
        do {
            sum += number % 10; //Extract the last digit and add it to sum
            number /= 10; //Remove the last digit and keep the remaining number            
        } while (number > 0);
        
        System.out.println("\nThe Sum of The Digits = " + sum + "\n");
        
        if (sum % 3 == 0)
            System.out.println(temp + " is Divisible By 3");
        else
            System.out.println(temp + " is Not Divisible By 3");
        
        if (sum % 9 == 0)
            System.out.println(temp + " is Divisible By 9");
        else
            System.out.println(temp + " is Not Divisible By 9");
        System.out.println();
    }
}