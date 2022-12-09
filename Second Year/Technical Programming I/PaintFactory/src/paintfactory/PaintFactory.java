package paintfactory;

import java.util.Scanner;

public class PaintFactory {
    
    public static void main(String[] args) {
        
        Scanner inFile = new Scanner(System.in);
        
        String code;
        
        int customers = 1;
        while (customers <= 100){ 
        System.out.print("Input Code of The Colour Wanted >> ");
        code = inFile.next();
        
        if ((code.equalsIgnoreCase("WT")) || (code.equalsIgnoreCase("GN")) || (code.equalsIgnoreCase("SR"))) {
            double litres;
            System.out.print("Input Number of Litres >> ");
            litres = inFile.nextDouble();
            if (litres > 0.0) {
                double price = 0.0;
                if (code.equalsIgnoreCase("WT")) {
                    price = 20 * litres;
                } else if (code.equalsIgnoreCase("GN")) {
                    price = 35 * litres;
                } else if (code.equalsIgnoreCase("SR")) {
                    price = 45 * litres;
                }
                
                if (price > 1000) {
                    price = price - (price * 0.1);
                }
                customers += 1;
                System.out.printf("Total Price = R%.2f%n%n", price);
            }else {
                System.out.println("\nNumber of Litres Must Be > 0\n");
            }
        } else {            
            System.out.println("\nInvalid Colour Code!\n");
        }
        }
    }   
}