package nondescending_order;

import java.util.Scanner;

public class Nondescending_Order {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        // Prompt the user to enter three integers
        System.out.print("Enter Three Integers: ");
        int number1 = input.nextInt();
        int number2 = input.nextInt();
        int number3 = input.nextInt();

        // Sort numbers
        int temp;
        if (number2 < number1 || number3 < number1)
        {
            if (number2 < number1)
            {
                temp = number1;
                number1 = number2;
                number2 = temp; 
            }
            if (number3 < number1)
            {
                temp = number1;
                number1 = number3;
                number3 = temp;
            }
        }
        if (number3 < number2)
        {
            temp = number2;
            number2 = number3;
            number3 = temp;
        }

        // Display numbers in Nondescending order
        System.out.println(number1 + " " + number2 + " " + number3);
    }   
}