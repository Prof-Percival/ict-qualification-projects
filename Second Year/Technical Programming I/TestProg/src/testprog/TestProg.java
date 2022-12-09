package testprog; //This statement was missing even though the program would run without it

import java.util.*; //The package name was incorrect on this import statement. It was java.utility instead of java.util 

public class TestProg
{
  static Scanner console = new Scanner(System.in);
  
  public static void main(String[] args) //The main method was not declared the right way. The return type was missing
 {
        int num1, num2, result; //There was a semi colon between the two variables (num2 and result) There was suppose to be a comma (,) not a semi-colon(;) 

       System.out.println("Enter the first number: ");
      num1 = console.nextInt(); //The expression for reading the data was incorrect. It was System.in() instead of console.nextInt()
      System.out.println("Enter the second number: "); //The out and println were not separated by the full stop and the Message was not enclosed in double quotation marks 
      num2 = console.nextInt(); //Wrong Scanner object was used. The object was scan instead of console

      result = (num1 * 2) % num2 - num1; //a non-existing or non-declared variable was used (nums1 instead of num1)
   System.out.println("The results of two numbers: " + result); //Incorrect concatenating operator was used (, instead of +)
   
  }
} //This curly bracket was missing 
