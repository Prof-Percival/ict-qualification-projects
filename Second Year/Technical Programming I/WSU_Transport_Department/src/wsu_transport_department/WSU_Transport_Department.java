package wsu_transport_department;

import java.util.Scanner;

public class WSU_Transport_Department {
    
    public static void main(String[] args) {
        
        Scanner inFile = new Scanner(System.in);
        
        int engineCapacity;
        double kilometers, totalAmount, rate = 0.0;
        
        System.out.print("Enter The Engine Capacity of The Vehicle: ");
        engineCapacity = inFile.nextInt();
        
        if (engineCapacity > 0) {
            if (engineCapacity >= 1 && engineCapacity <= 1600) {   
                rate = 2.50;   
            } else if (engineCapacity >= 1601 && engineCapacity <= 2500) {   
                rate = 3.00;   
            } else if (engineCapacity >= 2501 && engineCapacity <= 3500) {   
                rate = 3.50;   
            } else if (engineCapacity >= 3501 && engineCapacity <= 4500) {   
                rate = 4.00;   
            } else if (engineCapacity > 4500) {   
                rate = 4.50;           
            }
            System.out.printf("Rands per Kilometer is: R%.2f%n%n", rate);
            System.out.print("Enter The Number of Kilometers Travelled: ");
            kilometers = inFile.nextDouble();
            totalAmount = kilometers * rate;
            System.out.printf("Total Amount Claimed is: R%.2f%n%n", totalAmount);
        } else {   
            System.out.println("Invalid Engine Capacity \n");   
        }
    }   
}