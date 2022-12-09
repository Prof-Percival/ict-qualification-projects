package ch3exercise5;

/**
 *
 * @author Christoph
 */
import java.util.Scanner;

public class Percentages {
    
    static Scanner input = new Scanner(System.in);
    
    public static void main(String[] args){
        
        double value1, value2;
        
        System.out.print("Input First Value >> ");
        value1 = input.nextDouble();
        System.out.print("Input Second Value >> ");
        value2 = input.nextDouble();
        
        Percentages.computePercentage(value1, value2);
        Percentages.computePercentage(value2, value1);        
    }
    
    public static void computePercentage(double val1, double val2)
    {
        System.out.println("\nFirst Value: " + val1);
        System.out.println("Second Value: " + val2);
        System.out.println(val1 + " is " + ((val1/val2) * 100) + " Percent of " + val2);
    }
}