package ch3_prexercise1;

import java.util.Scanner;
import java.io.FileReader;
import java.io.PrintWriter;
import java.io.FileNotFoundException;

public class Ch3_PrExercise1 {

    public static void main(String[] args) throws FileNotFoundException
    
    {
        Scanner inFile = new Scanner(new FileReader("inData.txt"));
        PrintWriter outFile = new PrintWriter("outData.dat");
        
        double length, width, radius, savingsBalance, interestRate;
        String firstName, lastName;
        int age, p;
        final double pie = 3.1416;
        char letter, secLetter;
        
        length = inFile.nextDouble();
        width = inFile.nextDouble();
        radius = inFile.nextDouble();
        firstName = inFile.next();
        lastName = inFile.next();
        age = inFile.nextInt();
        savingsBalance = inFile.nextDouble();
        interestRate = inFile.nextDouble();
        letter = inFile.next().charAt(0);
        inFile.close();
        p = (int)letter;
        secLetter = (char)(p + 1);
        
        outFile.print("Rectangle: \n");
        outFile.printf("Length = %.2f, width = %.2f, area = %.2f, parameter = %.2f%n%n", length, width, (length * width), ((2 * length) + (2 * width)));
        outFile.print("Circle: \n");
        outFile.printf("Radius = %.2f, area = %.2f, circumference = %.2f%n%n", radius, (pie * (radius * radius)), (2 * pie * radius));
        outFile.printf("Name: %s %s, age: %d%n", firstName, lastName, age);
        outFile.printf("Beginning balance = $%.2f, interest rate = %.2f%n", savingsBalance, interestRate);
        outFile.printf("Balance at the end of the month = $%.2f%n%n", (savingsBalance + (savingsBalance * (interestRate / 12))));
        outFile.print("The character that comes after " + letter + " in the ASCII set is " + secLetter);
        
        outFile.close();

    }
    
}