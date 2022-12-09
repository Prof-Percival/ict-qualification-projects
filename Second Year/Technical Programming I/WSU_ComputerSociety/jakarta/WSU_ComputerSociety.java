package jakarta;

import java.util.Scanner;

public class WSU_ComputerSociety {

    public static void main(String [] java) {

	Scanner input = new Scanner(System.in);

	String tabs = "\n\t\t\t\t\t\t\t";


	System.out.println(tabs + "[   RUNNING...   ]");
	
	System.out.print("Input T-Shirt Size Code (S, M, L, XL) >> ");
	String code = input.nextLine();
	code = code.toUpperCase();
	if (code.equals("S") || code.equals("M") || code.equals("L") || code.equals("XL")){
		System.out.print("Input Number of T-Shirts >> ");
		int number = input.nextInt();
		if (number > 0){
		    int price = 0;
	    	    double discount = 0.0, totalCost = 0.0;	

		    if (code.equals("S"))
			price = 110 * number;
		    else
		    if (code.equals("M"))
			price = 115 * number;
	    	    else
		    if (code.equals("L"))
	    		price = 120 * number;
		    else
		    if (code.equals("XL"))
	    		price = 125 * number;

		    if (price >= 1000)
	    		discount = price * 0.15;

		    totalCost = price - discount;

		    code = (number > 1) ? "T-Shirts" : "T-Shirt";

		    System.out.printf("%nInitial Cost = R%d,00%n", price);
		    System.out.printf("Discount = R%.2f%n", discount);
		    System.out.printf("%s Total Cost = R%.2f%n", code, totalCost);
		} else
			System.out.println("\nNumber of Tickets Must Be Greater Than 0");
	    } else
		    System.out.println("\nInvalid T-Shirt Size Code");
    }
}