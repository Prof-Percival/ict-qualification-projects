package ch3exercise9;

/**
 *
 * @author Christoph
 */

import java.util.Scanner;

public class Insurance {

    static Scanner input = new Scanner(System.in);
    
    public static void main(String[] args) {
        
        int currentYear, birthYear;
        System.out.print("Input Current Year (i.e 2022) >> ");
        currentYear = input.nextInt();
        System.out.print("Input a Birth Year (i.e 1980) >> ");
        birthYear = input.nextInt();
        
        double premium = Insurance.premiumAmount(currentYear, birthYear);
        
        System.out.printf("%nPremium Amount = $%.2f%n", premium);
    }
    
    public static double premiumAmount(int cy, int by)
    {
        //Age = Current Year - Birth Year
        int age = cy - by;
        
        int decades = age / 10;
        
        System.out.println("\nAge = " + age);
        
        return ((decades + 15) * 20);
    }
}