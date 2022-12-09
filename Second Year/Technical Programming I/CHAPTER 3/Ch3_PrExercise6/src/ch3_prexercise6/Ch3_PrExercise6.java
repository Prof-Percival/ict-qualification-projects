package ch3_prexercise6;

import java.util.Scanner;
import java.io.FileReader;
import java.io.PrintWriter;
import java.io.FileNotFoundException;

public class Ch3_PrExercise6 {

    public static void main(String[] args) throws FileNotFoundException {
        
        Scanner inFile = new Scanner (new FileReader("inPercentage.txt"));
        Scanner Percival = new Scanner(System.in);
        PrintWriter outFile = new PrintWriter("outNetPay.dat");
        
        double grossSalary, federalIncomeTax, stateTax, socialSecurityTax, medicareTax, pensionPlan, netPay;
        final double HEALTH_INSURANCE = 75.00;
        String name;
        
        //Accepting Data From The User
        System.out.print("Input Emloyee's Full Name: ");
        name = Percival.nextLine();
        System.out.print("Input Employee's Gross Salary: ");
        grossSalary = Percival.nextDouble();
        
        //Reading Data From File & Performing Calculations
        
        //Federal Income Tax
        federalIncomeTax = inFile.nextDouble();
        federalIncomeTax = grossSalary * (federalIncomeTax / 100);
        
        //State Tax
        stateTax = inFile.nextDouble();
        stateTax = grossSalary * (stateTax / 100);
        
        //Social Security Tax
        socialSecurityTax = inFile.nextDouble();
        socialSecurityTax = grossSalary * (socialSecurityTax / 100);
        
        //Medicare or Medicaid Tax
        medicareTax = inFile.nextDouble();
        medicareTax = grossSalary * (medicareTax / 100);
        
        //Pension Plan
        pensionPlan = inFile.nextDouble();
        pensionPlan = grossSalary * (pensionPlan / 100);
        
        //Net Salary
        netPay = grossSalary - (federalIncomeTax + stateTax + socialSecurityTax + medicareTax + pensionPlan + HEALTH_INSURANCE);
        
        //Writing Data To a File
        outFile.println(name);
        outFile.printf("Gross Amount: $%.2f%n", grossSalary);
        outFile.printf("Federal Tax: $%.2f%n", federalIncomeTax);
        outFile.printf("State Tax: $%.2f%n", stateTax);
        outFile.printf("Social Security Tax: $%.2f%n", socialSecurityTax);
        outFile.printf("Medicare/Medicaid Tax: $%.2f%n", medicareTax);
        outFile.printf("Pension Plan: $%.2f%n", pensionPlan);
        outFile.printf("Health Insurance: $%.2f%n", HEALTH_INSURANCE);
        outFile.printf("Net Pay: $%.2f%n%n", netPay);
        outFile.printf("%n%36s", "Developed by Percival");
        
        //Closing Files
        inFile.close();
        outFile.close();
    }
    
}