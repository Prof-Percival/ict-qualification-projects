package file.inputoutput;

import java.util.*;
import java.io.*;

public class FileInputOutput {
    
    public static void main(String [] args) 
                                            throws FileNotFoundException
    {   
        Scanner fileIOInput = new Scanner (new FileReader("test.txt"));
        PrintWriter fileIOOutput = new PrintWriter("testavg.txt");

        
        String fName, lName;
        double test1, test2, test3, test4, test5, average;
        
        fName = fileIOInput.next();
        lName = fileIOInput.next();
        test1 = fileIOInput.nextDouble();
        test2 = fileIOInput.nextDouble();
        test3 = fileIOInput.nextDouble();
        test4 = fileIOInput.nextDouble();
        test5 = fileIOInput.nextDouble();
        
        average = (test1 + test2 + test3 + test4 + test5) / 5;
        
        for (int p = 0; p < 1; p++){
        
        fileIOOutput.printf("Student's Name: %s %s%n", fName,lName);
        fileIOOutput.println();
        fileIOOutput.printf("Test 1 Score = %.2f%s%n", test1, "%");
        fileIOOutput.printf("Test 2 Score = %.2f%s%n", test2, "%");
        fileIOOutput.printf("Test 3 Score = %.2f%s%n", test3, "%");
        fileIOOutput.printf("Test 4 Score = %.2f%s%n", test4, "%");
        fileIOOutput.printf("Test 5 Score = %.2f%s%n", test5, "%");
        fileIOOutput.println();
        fileIOOutput.println(String.format("Average of the Five Test Scores = %.2f%s%n", average, "%"));
        fileIOOutput.printf("%s%n%n","====================================================================");
        
        }
        fileIOInput.close();
        fileIOOutput.close();
        
    }

}