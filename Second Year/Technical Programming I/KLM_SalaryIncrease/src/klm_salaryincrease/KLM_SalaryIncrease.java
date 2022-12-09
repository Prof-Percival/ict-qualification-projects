package klm_salaryincrease;

import java.util.Scanner;

public class KLM_SalaryIncrease {
    
    public static void main(String[] args) {
        
        Scanner input = new Scanner (System.in);
        
        System.out.println("Perfomance Ratings: (Excellent, Very-Good, Good, Fair & Poor)");
        System.out.print("Input Employee\'s Perfomance Rating >> ");
        String rating = input.next();
        
        double currentSalary, raiseAmount, newSalary, costToCompany;
        raiseAmount = 0.0;
        costToCompany = 0.0;
        
        while (!rating.equalsIgnoreCase("ZZZ")){
            if (rating.equals("Excellent") || rating.equals("Very-Good") || rating.equals("Good") || rating.equals("Fair") || rating.equals("Poor")){
                //input.nextLine();
                System.out.print("Input Employee\'s Current Salary >> ");
                currentSalary = input.nextDouble();
                if (currentSalary > 0.0){
                    switch (rating){ //Determining The Raise Amount
                        case "Excellent" -> 
                            raiseAmount = currentSalary * (10 / 100.0);
                        case "Very-Good" ->
                            raiseAmount = currentSalary * (6 / 100.0);
                        case "Good" ->
                            raiseAmount = currentSalary * (4 / 100.0);
                        case "Fair" ->
                            raiseAmount = currentSalary * (1.5 / 100);
                        case "Poor" ->
                            raiseAmount = 0;
                    }
                    //New Salary
                    newSalary = currentSalary + raiseAmount;
                    
                    //Accumulating Total Cost To Company
                    costToCompany += newSalary;
                    
                    //Displaying
                    System.out.printf("%nCurrent Salary: R%.2f%n", currentSalary);
                    System.out.printf("Perfomance Rating: %s%n", rating);
                    System.out.printf("Amount of Raise: R%.2f%n", raiseAmount);
                    System.out.printf("The New Salary: R%.2f%n%n", newSalary);
                }else
                    System.out.println("\nEmployee\'s Current Salary Must Be > R0\n");
            } else 
                System.out.println("\nIllegal Response, No Raise Given\n");

            //New Input
            System.out.println("Perfomance Ratings: (Excellent, Very-Good, Good, Fair & Poor)");
            System.out.print("Input Employee\'s Perfomance Rating >> ");
            rating = input.next();
        }
        //Displaying Total Cost To Company
        System.out.printf("%nTotal Cost To Company (p/m): R%.2f%n", costToCompany);
    }
}