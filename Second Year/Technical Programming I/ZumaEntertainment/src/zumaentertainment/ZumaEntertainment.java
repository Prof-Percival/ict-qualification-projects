package zumaentertainment;

import java.util.Scanner;

public class ZumaEntertainment {

    public static void main(String[] args) {
        
        Scanner inFile = new Scanner (System.in);
        
        int age, companyPrice = 0;
        int ticketPrice = 0;
        int p = 1;
        
        while (p <= 500){
            System.out.print("Input Your Age >>  ");
            age = inFile.nextInt();
            if (age < 16)
                ticketPrice = 50;
            else
                if (age >= 16 && age <= 55)
                    ticketPrice = 55;
                else
                    if (age > 55)
                        ticketPrice = 25;
            System.out.println("\nTicket Price = R" + ticketPrice + "\n");
            p += 1;
            companyPrice += ticketPrice;
        }
        System.out.println("Total Amount Company Made = R" + companyPrice);
    }   
}