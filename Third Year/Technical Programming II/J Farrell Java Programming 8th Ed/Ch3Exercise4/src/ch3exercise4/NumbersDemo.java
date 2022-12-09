package ch3exercise4;

/**
 *
 * @author Christoph
 */

import java.util.Scanner;

public class NumbersDemo {

    static Scanner input = new Scanner(System.in);

    public static void main(String[] args) {
        
        int value1, value2;
        
        System.out.print("Input First Value >> ");
        value1 = input.nextInt();
        System.out.print("Input Second Value >> ");
        value2 = input.nextInt();
        
        NumbersDemo.displayTwiceTheNumber(value1);
        NumbersDemo.displayTwiceTheNumber(value2);
        
        System.out.println();
        
        NumbersDemo.displayNumberPlusFive(value1);
        NumbersDemo.displayNumberPlusFive(value2);
        
        System.out.println();
        
        NumbersDemo.displayNumberSquared(value1);
        NumbersDemo.displayNumberSquared(value2);
        System.out.println();
        
    }
    
    public static void displayTwiceTheNumber(int value)
    {
        System.out.println(value + " Twice = " + (value * 2));
    }
    
    public static void displayNumberPlusFive(int value)
    {
        System.out.println(value + " + 5 = " + (value + 5));
    }
    
    public static void displayNumberSquared(int value)
    {
        System.out.println(value + " Squared = " + (int) Math.pow(value, 2));
    }
}