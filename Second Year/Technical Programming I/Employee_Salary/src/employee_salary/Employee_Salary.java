package employee_salary;

import java.util.Scanner;

public class Employee_Salary {

    static Scanner console = new Scanner(System.in);
    static final int HOUSING_ALLOWANCE = 1500;
    
    public static void main(String[] args) {
    
        String name;
        int grossSalary, pension, medicalAid;
        double netSalary, tax;
        
        System.out.print("Input Employee's Name >> ");
        name = console.nextLine();
        System.out.print("Input Gross Salary >> ");
        grossSalary = console.nextInt();
        System.out.print("Input Pension Amount >> ");
        pension = console.nextInt();
        System.out.print("Input Medical Aid Amount >> ");
        medicalAid = console.nextInt();
        
        tax = (grossSalary + HOUSING_ALLOWANCE) * 0.15;
        netSalary = (grossSalary + HOUSING_ALLOWANCE) - (tax + pension + medicalAid);
        
        System.out.println();
        System.out.println("Pay Slip - Mentos Pty Ltd");
        System.out.println("*********************************************");
        System.out.println("Salary Advice for " + name + "\n");
        System.out.println("Gross Salary: R " + grossSalary);
        System.out.println("Housing Allowance: " + HOUSING_ALLOWANCE + "\n");
        System.out.println("Tax: R " + tax);
        System.out.println("Medical Aid: R " + medicalAid);
        System.out.println("Pension: R " + pension + "\n");
        System.out.println("Net Salary: R " + netSalary);
        System.out.println("*********************************************");
        
    }
    
}