package wsu_dramaticsociety;

import java.util.Scanner;

public class WSU_DramaticSociety {

    public static void main(String[] args) {
        
        Scanner inFile = new Scanner(System.in);
        
        System.out.print("Input Customer Type (S, P, or X) >> "); //S - Student, P - Pensioner, X - Other
        char customerType = inFile.next().charAt(0);

        int tickets;
        
        customerType = Character.toUpperCase(customerType);
        
        int ticketsPrice;
        double discount = 0.0;
        double totalPrice;
        
        while (customerType != 'Z'){
            if (customerType == 'S' || customerType == 'P' || customerType == 'X'){
                System.out.print("Input Number of Tickets >> ");
                tickets = inFile.nextInt();
                if (tickets > 0){
                    ticketsPrice = 50 * tickets;
                    if (customerType == 'S'){
                        discount = ticketsPrice * 0.1;
                    } else
                        if (customerType == 'P'){
                            discount = ticketsPrice * 0.2;
                        }
                    totalPrice = ticketsPrice - discount;
                    System.out.printf("Total Amount (Before Discount) = R%d,00%n", ticketsPrice);
                    System.out.printf("Discount Amount = R%.2f%n", discount);
                    System.out.printf("Total Amount (After Discount) = R%.2f%n%n", totalPrice);
                }else
                 System.out.println("\nNumber of Tickets Must Be Greater Than 0\n");
            }else
                System.out.println("\nInvalid Customer Type\n");
            
            System.out.print("Input Customer Type (S, P, or X) >> "); //S - Student, P - Pensioner, X - Other
            customerType = inFile.next().charAt(0);        
            customerType = Character.toUpperCase(customerType);
        }  
    }   
}