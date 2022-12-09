package cablecompanybilling;

import java.util.Scanner;

public class CableCompanyBilling {

    public static void main(String[] args) {
        
        //Creating object for our Scanner class
        Scanner inFile = new Scanner(System.in);
        
        //Declaring variables
        int customerNumber, noBasicService, noPremiunChannels;
        char code;
        double bill = 0.0;
        
        //Accepting Customer's Account Number
        System.out.print("Input Customer's Account Number: ");
        customerNumber = inFile.nextInt();
        
        //Creating NewLine
        System.out.println();
        
        //Accepting Customer's Code
        System.out.print("Input Customer Type Code (R / r) or (B / b): ");
        code = inFile.next().charAt(0);
        
        //Creating NewLine
        System.out.println();
        
        if ((code == 'R' || code == 'r') || (code == 'B' || code == 'b')){
            if (code == 'R' || code == 'r'){
                System.out.print("Input Number of Premiun Channels: ");
                noPremiunChannels = inFile.nextInt();
                bill = 4.50 + 20.50 + (7.50 * noPremiunChannels);                
            }
            if (code == 'B' || code == 'b'){
                System.out.print("Input Number of Premiun Channels: ");
                noPremiunChannels = inFile.nextInt();
                
                //Creating NewLine
                System.out.println();
                
                System.out.print("Input Number of Basic Service Connections: ");
                noBasicService = inFile.nextInt();
                if (noBasicService > 10){
                    bill = 15.00 + 75.00 + ((noBasicService - 10) * 5.00) + (50.00 * noPremiunChannels);
                } else if (noBasicService <= 10){
                    bill = 15.00 + 75.00 + (50.00 * noPremiunChannels);
                }
            }
            System.out.println("\n\n\t\t\t ***Bill***");
            System.out.println("\nAccount Number: " + customerNumber);
            System.out.printf("%nAmount Due: $%.2f%n%n", bill);
        } else {
            System.out.println("Invalid Customer Type Code\n");
        }
    }
}