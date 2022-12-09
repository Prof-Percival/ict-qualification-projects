package ch3_prexercise5;

import java.util.Scanner;
import java.io.*;

public class Ch3_PrExercise5 {

    public static void main(String[] args) throws FileNotFoundException {
        
        Scanner inFile = new Scanner(new FileReader("inTicketsSold.txt"));
        PrintWriter outFile = new PrintWriter("outTicketsSold.dat");
        
        double priceBox, priceSideline, pricePremiun, priceGenAdmission;
        int box, sideline, premiun, genAdmission;
        
        priceBox = inFile.nextDouble();
        box = inFile.nextInt();
        
        priceSideline = inFile.nextDouble();
        sideline = inFile.nextInt();
        
        pricePremiun = inFile.nextDouble();
        premiun = inFile.nextInt();
        
        priceGenAdmission = inFile.nextDouble();
        genAdmission = inFile.nextInt();
        
        outFile.println("Box Tickets:");
        outFile.printf("Tickets = %d   Total Sale Amount = $%.2f%n%n", box, (priceBox * box));
        outFile.println("Sideline Tickets:");
        outFile.printf("Tickets = %d   Total Sale Amount = $%.2f%n%n", sideline, (priceSideline * sideline));
        outFile.println("Premiun Tickets:");
        outFile.printf("Tickets = %d   Total Sale Amount = $%.2f%n%n", premiun, (pricePremiun * premiun));
        outFile.println("General Admission Tickets:");
        outFile.printf("Tickets = %d   Total Sale Amount = $%.2f%n%n%36s", genAdmission, (priceGenAdmission * genAdmission), "Developed by Christoph Percival");
        
        inFile.close();
        outFile.close();
        
    }
    
}
