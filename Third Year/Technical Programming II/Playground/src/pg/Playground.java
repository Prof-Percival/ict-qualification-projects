package pg;

/**
 *
 * @author Christoph
 */

import java.util.Scanner;
import java.io.*;
import java.util.Arrays;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

public class Playground {
    
    public static void main(String[] args)throws FileNotFoundException {
        
        try {
            File dataFile = new File("Jobs.dat");
            if (dataFile.exists()){
                System.out.println("File Exists");
                
            }
            FileInputStream file =new FileInputStream(dataFile);
            System.out.println("AH 1");
            ObjectInputStream inputfile = new ObjectInputStream(file);
            
            System.out.println("AH2");
            boolean endOfFile=false;
            while(!endOfFile)
            {
                try
                {
                    System.out.println(inputfile.readObject());
                }
                catch(EOFException e)
                {
                    endOfFile=true;
                }
                catch(IOException | ClassNotFoundException f)
                {
                    JOptionPane.showMessageDialog(null, f.getMessage());
                }
            }
            
            file.close();
            inputfile.close();
            System.out.println("\n\n");
            //Scanner inFile = new Scanner(new FileReader("inputData.txt"));
            StringBuffer mainValue = new StringBuffer("Tshililo");
            
            System.out.println("String Manipulation");
            System.out.println("In MAIN: " + mainValue);
            manipulateString(mainValue);
            System.out.println("In MAIN (After Manipulation): " + mainValue);
            
            int num = 11;
            System.out.println("String Manipulation");
            System.out.println("In MAIN: " + num);
            manipulateNumber(num);
            System.out.println("In MAIN (After Manipulation): " + num);
        } catch (IOException ex) {
            Logger.getLogger(Playground.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    public static void manipulateString(StringBuffer value)
    {
        System.out.println("In METHOD: " + value);
        value.append("77");
        System.out.println("In METHOD (After Manipulation): " + value);
        
    }

    private static ObjectInputStream ObjectInputStream(FileInputStream file) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
    public void findSum(int num1, int num2)
    {
        System.out.println(num1 + num2);
    }
   
    
     public void findSum(int num1, double num2)
    {
        System.out.println(num1 + num2);
    }
     
     public void findSum(double num1, int num2)
    {
        System.out.println(num1 + num2);
    }
     
      public void findSum(double num1, double num2)
    {
        System.out.println(num1 + num2);
    }
    
    
    public static void manipulateNumber(int value)
    {
        System.out.println("In METHOD: " + value);
        value = value + 77;
        System.out.println("In METHOD (After Manipulation): " + value);
        
    }
    
    
    public void displayName(String name)
    {
	System.out.println("Your Name is: " + name);
        
        int[] marks3 = {45, 88, 85, 90};
        averageMark(marks3, 4);
    }
    
    public static int findMin(int num1, int num2){
    
        int minNum = 0;
        if (num1 < num2)
            minNum = num1;
        else
            minNum = num2;
        
        
        return minNum;
        
    }
    
    public static double larger(double num1, double num2){
        
        if (num1 > num2)
            return num1;
        else
            return num2;      
    }
    
    public static void averageMark(int marks[], int size)
    {
        double sum = 0.0;
        
        for (int i = 0; i < size; i++)
        {
            sum += marks[i];
        }
        
        System.out.printf("Average of All Marks: %.2f%n", (sum / size));
    }
}
