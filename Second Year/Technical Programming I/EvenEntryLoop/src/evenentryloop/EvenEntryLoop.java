package evenentryloop;

import java.util.Scanner;

public class EvenEntryLoop {

    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);
        
        System.out.print("Input An Even Number or Sentinel Value 999 To Stop The Program >> ");
        int number = input.nextInt();
        
        while (number != 999) {
            if (number % 2 == 0)
                System.out.println("\nGood job!");
            else
                System.out.println("\nInput Must Not Be an Odd Number");
            
            //Take New Input
            System.out.print("\nInput An Even Number or Sentinel Value 999 To Stop The Program >> ");
            number = input.nextInt();
        }
    }   
}