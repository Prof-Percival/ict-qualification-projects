package ch3exercise7;

/**
 *
 * @author Christoph
 */

import java.util.Scanner;

public class MetricConversion {

    static Scanner input = new Scanner(System.in);
    static final double CENTIMETERS = 2.54;
    static final double LITERS = 3.7854;
    
    public static void main(String[] args) {
    
        int value;
        
        System.out.print("Input a Value To Convert >> ");
        value = input.nextInt();
        
        MetricConversion.inchToCentimeter(value);
        MetricConversion.gallonToLiter(value);
    }
    
    public static void inchToCentimeter(int val)
    {
        System.out.println("\n" + val + " Inches = " + (CENTIMETERS * val) + " Centimeters");
    }
    
    public static void gallonToLiter(int val)
    {
        System.out.println("\n" + val + " U.S Gallons = " + (LITERS * val) + " Liters");
    }
}