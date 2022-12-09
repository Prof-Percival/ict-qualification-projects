package siya_fs;

import java.util.Scanner;

public class Siya_FS {

    public static void main(String[] args) {
            
        Scanner inFile = new Scanner(System.in);
        
        final int SMALL = 50, MEDIUM = 70, LARGE = 90, DELIVERY_FEE = 10;
        
        char size;
        
        System.out.print("Input Flower\'s Size (S, M or L) >> ");
        size = inFile.next().charAt(0);
        size = Character.toUpperCase(size);
        
        if ((size == 'S') || (size == 'M') || (size == 'L')) {
            double distance;
            System.out.print("\nInput the Distance (in KMs) >> ");
            distance = inFile.nextDouble();
            if (distance > 0.0) {
                double total = 0;
                if (size == 'S') {
                    total = SMALL + (distance * DELIVERY_FEE);
                } else if (size == 'M') {
                    total = MEDIUM + (distance * DELIVERY_FEE);
                } else if (size == 'L') {
                    total = LARGE + (distance * DELIVERY_FEE);
                }
                System.out.printf("%nTotal Amount = R%.2f%n", total);
            } else {
                System.out.print("\nDistance Value Must Be > 0Km\n");
            }
        } else {
            System.out.print("\nInvalid Flower\'s Size!\n");
        }
    }
}