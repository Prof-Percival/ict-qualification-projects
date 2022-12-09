package ch3exercise11;

/**
 *
 * @author Christoph
 */

import java.util.Scanner;

public class TestSandwich {

    static Scanner input = new Scanner(System.in);
    
    public static void main(String[] args) {
 
        Sandwich sandwich = new Sandwich();
        
        sandwich.setMainIngredient("Tuna");
        sandwich.setBreadType("Wheat");
        sandwich.setPrice(3);
        System.out.println("Sandwich Main Ingredient: " + sandwich.getMainIngredient());
        System.out.println("Sandwich Bread Type: " + sandwich.getBreadType());
        System.out.println("Sandwich Price: $" + sandwich.getPrice());
        System.out.println();
        System.out.println("Sandwich object -> toString()");
        System.out.println(sandwich);
    }   
}