package ch3_prexercise7;

import java.util.*;
import java.io.*;

public class Ch3_PrExercise7 { 
    
    public static void main(String[] args) throws FileNotFoundException {
        
        Scanner inFile = new Scanner (new FileReader ("Ch3_Ex7Data.txt"));
        PrintWriter outFile = new PrintWriter("Ch3_Ex7Output.dat");
        
        String firstName, lastName;
        double currentSalary, updatedSalary, payIncrease;
        
        //Begining of  Iteration 
        for (int P = 0; P < 3; P++){
            
        firstName = inFile.next();
        lastName = inFile.next();
        currentSalary = inFile.nextDouble();
        payIncrease = inFile.nextDouble();
        
        //Calculating New Increased Salary
        updatedSalary = (currentSalary + (currentSalary * (payIncrease / 100)));
        
        outFile.printf("%s %s R%.2f%n",firstName, lastName, updatedSalary);
        
        }
        //Close the Reading From File
        inFile.close();
        
        //Close the Reading To File
        outFile.close();  
    }
    
}