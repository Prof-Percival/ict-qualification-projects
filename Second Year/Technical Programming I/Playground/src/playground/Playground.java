package playground;

import playground.YVClass;

import java.util.Scanner;
//import static java.lang.Math.*;

public class Playground {
    
    static Scanner input = new Scanner(System.in);
    
    public static void main(String[] args) {
        // TODO code application logic here
        /*static Scanner input = new Scanner(System.in);
        StringBuffer name = new StringBuffer("Java");
        System.out.println(name);
        ChangeString(name);
        System.out.println(name);
    }
    public static void ChangeString(StringBuffer val2){
       val2.delete(0, val2.length());
    */
        /*
        String name = "Yongama";
        String surname = "Makeleni";
        int age = 30;
        //System.out.printf("Name is %3$s & Surname is %1$s. Age is %2$d%n", surname, age, name);
        //System.out.printf("%10.2f 1 + 1 = 2 Yongama%n", 56.9567);
        System.out.println((int)(9.5 % 5 + 21 - 6));
           */

        
        //System.out.println("vyPow of 7: " + 1.0);
        
        //if (vyPow(7, 2))
          //  System.out.println("Method Executed Successfully");
          System.out.println("Successfully");
            
    }
    public static double vyPow(double base, int exp){
        double pow = base;
        
        if (exp > 1){
        exp -= 1;
        
        for (int p = 1; p <= exp; p++)
            pow *= base;
        }
        
        if (exp == 0)
            pow = 1;
        
        return pow;
        
    }
    
     /*
    public static double vymin(double num1, double num2){
        
        if (num1 <= num2)
            return num1;
        else
            return num2;
       
    }
    
    public static double vymax(double num1, double num2){
        
        if (num1 >= num2)
            return num1;
        else
            return num2;
       
    }
    */
}