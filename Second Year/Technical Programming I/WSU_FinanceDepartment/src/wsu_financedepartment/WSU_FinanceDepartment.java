package wsu_financedepartment;

import java.util.Scanner;

public class WSU_FinanceDepartment {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        
        System.out.println("Course Codes: IT, AC, ME, EE");
        System.out.print("Input Course Code: ");
        String code = input.next();
        
        double courseFee, loanAmount = 0.0, interest, totalAmount, installment, overallTotal = 0.0;
        String description= "";
        
        while (!code.equalsIgnoreCase("XX")){
            code = code.toUpperCase();
            if (code.equals("IT") || code.equals("AC") || code.equals("ME") || code.equals("EE")){
                System.out.print("Input Course Fee: ");
                courseFee = input.nextDouble();
                switch (code){
                    case "IT" -> {
                        description = "Information Technology";
                        loanAmount = courseFee + courseFee * (25 / 100.0);
                    }
                    case "AC" -> {
                        description = "Analytical Chemistry";
                        loanAmount = courseFee + courseFee * (35 / 100.0);
                    }
                    case "ME" -> {
                        description = "Mechanical Engineering";
                        loanAmount = 5000 + courseFee * (10 / 100.0);
                    }
                    case "EE" -> {
                        description = "Electrical Engineering";
                        loanAmount = 10000 + courseFee * (5 / 100.0);
                    }
                }
                interest = loanAmount * (20 / 100.0);
                totalAmount = loanAmount + interest;
                installment = totalAmount / 6;
                overallTotal += totalAmount;
                System.out.printf("%nStudent's Course: %s%n", description);
                System.out.printf("Loan Amount = R%.2f%n", loanAmount);
                System.out.printf("Interest (20%%) = R%.2f%n", interest);
                System.out.printf("Total Loan Amount: R%.2f%n", totalAmount);
                System.out.printf("Installment = R%.2f%n%n", installment);                
            }else
                System.out.println("\nInvalid Course Code\n");
            
            //New Input
            System.out.println("Course Codes: IT, AC, ME, EE");
            System.out.print("Input Course Code: ");
            code = input.next();
        }
        System.out.printf("\nOverall Total Amount Made for Loans = R%.2f%n", overallTotal);
    }   
}