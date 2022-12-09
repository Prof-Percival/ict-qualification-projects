package ch3_prexercise3;

import java.util.Scanner;

public class Ch3_PrExercise3 {
    
    public static void main(String[] args) {
    
        Scanner Percival = new Scanner(System.in);
        
        double weight;
        final double pounds = 2.2;
        
        System.out.print("Input the Weight of a Person in Kgs >> ");
        weight = Percival.nextDouble();
        
        System.out.println();
        
        System.out.printf("Weight in Kilograms = %.2fKg%n", weight);
        System.out.printf("Weight in Pounds = %.2flbs%n%n", (weight * pounds));
    }
    
}
