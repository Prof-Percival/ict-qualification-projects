package ch3_prexercise8;

import java.util.Scanner;

public class Ch3_PrExercise8 {

    public static void main(String[] args) {
        
        Scanner Percival = new Scanner (System.in);
        
        double mass, density, volume;
        
        System.out.print("Input te Mass (in grams) >> " );
        mass = Percival.nextDouble();
        
        System.out.print("Input Density (in grams per cubic centimeters) >> ");
        density = Percival.nextDouble();
        
        volume = density / mass;
        
        System.out.println();
        System.out.printf("Mass = %.2f%n", mass);
        System.out.printf("Density = %.2f%n", density);
        System.out.printf("Volume = %.2f%n%n", volume);
    }
    
}
