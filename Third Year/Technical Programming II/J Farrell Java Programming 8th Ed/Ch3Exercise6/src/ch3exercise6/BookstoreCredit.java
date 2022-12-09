package ch3exercise6;

/**
 *
 * @author Christoph
 */

import java.util.Scanner;

public class BookstoreCredit {

    static Scanner input = new Scanner(System.in);

    public static void main(String[] args) {
        String name;
        double gradePointAverage;
        System.out.print("Input Your Name >> ");
        name = input.nextLine();
        
        System.out.print("Input Your Grade Point Average (GPA) >> ");
        gradePointAverage = input.nextDouble();
        
        BookstoreCredit.computeCredit(name, gradePointAverage);
    }
    
    public static void computeCredit(String name, double gpa)
    {
        System.out.println("\nName: " + name);
        System.out.println("Grade Average Point = " + gpa);
        System.out.println("Congratulations " + name + "! You Got Yourself A Bookstore Credit of $" + (gpa * 10));
    }
}