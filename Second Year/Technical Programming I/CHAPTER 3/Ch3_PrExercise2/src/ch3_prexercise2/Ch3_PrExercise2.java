package ch3_prexercise2;

import java.util.*;

public class Ch3_PrExercise2
{
    static Scanner console = new Scanner(System.in);
    static final double PI = 3.14159;
    
    public static void main(String[] args)
    {
        double height;
        double radius;
        
        System.out.print("Enter the height of the cylinder: ");
        height = console.nextDouble();
        
        System.out.print("Enter the radius of the base of the cylinder: ");
        radius = console.nextDouble();
        
        System.out.println();
        
        System.out.printf("Volume of the cylinder = %.2f", (PI * Math.pow(radius, 2.0) * height));
        
        System.out.println();
        
        System.out.printf("Surface area: %.2f", ((2 * PI * Math.pow(radius, 2.0)) + (2 * PI * radius * height)));
        
         System.out.println("\n");
    }
}
