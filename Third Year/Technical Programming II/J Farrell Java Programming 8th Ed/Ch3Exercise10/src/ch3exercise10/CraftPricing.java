package ch3exercise10;

/**
 *
 * @author Christoph
 */

import java.util.Scanner;

public class CraftPricing {

    static Scanner input = new Scanner(System.in);
    
    public static void main(String[] args) {
    
        String name;
        double costOfMaterials;
        int hours;
        
        System.out.print("Input Product Name >> ");
        name = input.nextLine();
        System.out.print("Input Cost of Materials >> ");
        costOfMaterials = input.nextDouble();
        System.out.print("Input Number of Hours of Work Required >> ");
        hours = input.nextInt();
        
        double price = CraftPricing.retailPrice(costOfMaterials, hours);
        
        System.out.println("\nProduct Name: " + name);
        System.out.printf("Product Retail Price = $%.2f%n", price);
        
    }
    
    public static double retailPrice(double cost, int hours)
    {
        return ((cost + 12) * hours + 7);
    }
}