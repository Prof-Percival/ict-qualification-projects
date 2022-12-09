package school_salary;

//Importing The Scanner Class
import java.util.*;
/* public specifies that the access here is public
    class identifies School_Salary as a Class
    School_Salary is the name of the class
*/
public class School_Salary { //This is the class Header
    
    static Scanner console = new Scanner(System.in);
    
    /* public specifies that acces to the main Method is public
        static means this Method works without calling (instantiating) an Object (Constructor) of the Class
        Void is the Method's return type (Void means empty) so in this case it means the Method musn't return anything
        String - any arguments to this Method must be String objects (Statements)
        args argues / identifies that the arguments to this Method must be String*************(Not Sure) 
    */   
    public static void main(String[] args) { //This is the Method header
        
        //Declaration of:         
        //Constant here        
        final double RATE = 15.50;
        
        //Variables here
        int Hours;
        double BeforeTax, AfterTax, Tax, Rent, School_Supplies, Net;        
        
        //Main Messages To The Screen (Net for Decoration)
        System.out.println("My Name Is \"Percival\", The Programmer of This Program!\n");
        
        //Promt the User and Assigning Value to Hours Variable
        System.out.print("Input Hours Worked >> ");
        Hours = console.nextInt();
        
        //Calculations
        BeforeTax = Hours * RATE;
        Tax = BeforeTax * 0.14;
        AfterTax = BeforeTax - Tax;
        Rent = AfterTax * 0.25;
        School_Supplies = AfterTax * 0.10;
        Net = AfterTax - (Rent + School_Supplies);
        
        //Displaying Outputs        
        System.out.println();
        System.out.println("Hours Worked = " + Hours + "\n"); //Not Asked to Display
        System.out.println("Income Before Tax = R" + BeforeTax);
        System.out.println("Income After Tax = R" + AfterTax);
        System.out.println("Money Spent on Rent = R" + Rent);
        System.out.println("Money Spent on School Supplies = R" + School_Supplies);
        System.out.println("Money Left for Miscellaneous = R" + Net + "\n");        
    } //End of Method Body

} //End of CLass Body
