package ch3exercise8;

/**
 *
 * @author Christoph
 */

import java.util.Scanner;
import java.io.PrintStream;

public class PaintCalculator {
    
    static Scanner input = new Scanner(System.in);
    
    public static void main(String[] args) {
        
        PrintStream display = new PrintStream(System.out);
        
        double length, width, height;
        
        System.out.print("Input a House\'s Length >> ");
        length = input.nextDouble();
        System.out.print("Input a House\'s Width >> ");
        width = input.nextDouble();
        display.print("Input a House\'s Height >> ");
        height = input.nextDouble();
        
        double paintPrice = calculatePaintPrice(length, width, height);
        
        display.printf("%nTotal Paint Price = $%.2f%n", paintPrice);
        
        
    }
    
    public static double calculatePaintPrice(double l, double w, double h)
    {
        double wallArea = (2 * (l * h) + (2 * (w * h)));
        
        int gallonsOfPaint = PaintCalculator.calculateGallons(wallArea);
        
        System.out.println("\nNumber of Gallons of Paint Needed = " + gallonsOfPaint);
        
        double price = gallonsOfPaint * 32;
        
        return price;
    }
    
    public static int calculateGallons(double area)
    {
        int gallons = 0;
        if (area % 350 >= 0.5 || area % 350 == 0)
            gallons = (int) (Math.round(area / 350));
        else
            gallons = (int) (Math.round(area / 350) + 1);
        
        return gallons;
    }
}