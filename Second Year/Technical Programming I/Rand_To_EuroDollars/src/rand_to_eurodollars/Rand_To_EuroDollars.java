package rand_to_eurodollars;

import java.util.Scanner;
import java.lang.Math;

public class Rand_To_EuroDollars {

    private static final double RAND_DOLLARS = 14.71d;
    private static final double RAND_EURO = 17.32d;
    
    public static void main(String[] args) {
        
        Scanner Percival = new Scanner(System.in);
        double rands, euros, dollars;
        
        System.out.print("Input an Amount to Convert (in Rands) >> ");
        rands = Percival.nextDouble();
        
        euros = rands / RAND_DOLLARS;
        
        dollars = rands / RAND_EURO;
        
        System.out.println();
        System.out.println("Rands To \"Euros\" & \"Dollars\"\n");
        System.out.printf("Rands: R%.2f%n", rands);
        System.out.printf("Euros: €%.2f%n", euros);
        System.out.printf("Dollars: $%.2f%n%n", dollars);
    }
    
}
