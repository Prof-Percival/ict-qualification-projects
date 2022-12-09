package wsu_cs;

import java.util.Scanner;
import java.lang.Math;

public class WSU_CS {

    public static void main(String[] args) {
        Scanner inFile = new Scanner (System.in);
        int option;
        double area;
        
        System.out.print("Input Option (1, 2 or 3) >> ");
        option = inFile.nextInt();
        
         if (option == 1) {
            double length, width;
            System.out.print("\nInput Rectangle\'s Length: ");
            length = inFile.nextDouble();
            System.out.print("Input Rectangle\'s Width: ");
            width = inFile.nextDouble();
            area = length * width;
            System.out.print("\nRectangle\'s Area = " + area + "\n");
            
         } else if (option == 2) {
             double radius;
             System.out.print("\nInput Circle\'s Radius: ");
             radius = inFile.nextDouble();
             area = 3.14 * Math.pow(radius, 2);
             System.out.print("\nCircle\'s Area = " + area + "\n");
             
         } else if (option == 3) {
             double base, height;
             System.out.print("\nInput Triangle\'s Base: ");
             base = inFile.nextDouble();
             System.out.print("Input Triangle\'s Height: ");
             height = inFile.nextDouble();
             area = (base * height) / 2;
             System.out.print("\nTriangle\'s Area = " + area + "\n");
             
         } else {
             System.out.print("\nInvalid Input Option!\n");
         }
    }  
}