package javaapplication22;

import java.util.Scanner;

public class JavaApplication22 {

    public static void main(String[] args) {
        
        Scanner thabo = new Scanner(System.in);
        
        String name, name1;
        String idNumber;
        double paper, cardboard, totalpaper, totalcard, total;
        
        
        System.out.print("Enter name ");
        name = thabo.nextLine();
        
        System.out.print("Enter ID Number ");
        idNumber = thabo.next();
        
        System.out.print("Enter Kilograms for paper ");
        paper = thabo.nextDouble();
        
        System.out.print("Enter Kilograms for Cardboard ");
        cardboard = thabo.nextDouble();
        
        name1 = name.toUpperCase();
        
        totalpaper = paper * 2.05;
        totalcard = cardboard * 2.20;
        
        total = totalpaper + totalcard;
        System.out.println();
        System.out.println("Name is " + name1);
        System.out.println("Total Price For Paper is R" + totalpaper);
        System.out.println("Total Price For Cardboard is R" + totalcard);
        System.out.println("Total Price for Both is R" + total + "\n");

        

    }
    
}
