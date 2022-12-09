package practical18052022;

/**
 *
 * @author Christoph
 */

import java.util.Scanner;

public class Tester {

    static Scanner input = new Scanner(System.in);
    
    public static void main(String[] args) {

        Rectangle rectangle = new Rectangle(20, 10);
        Triangle triangle = new Triangle(20, 10);

        System.out.println(rectangle);
        System.out.println();
        System.out.println(triangle);

        int length;
        int width;


        System.out.print("\nInput The Length >> ");
        length = input.nextInt();

        System.out.print("Input The Width >> ");
        width = input.nextInt();

        System.out.println();

        rectangle.setLength(length);
        rectangle.setWidth(width);      
        System.out.println(rectangle);

        System.out.println();

        triangle.setLength(length);
        triangle.setWidth(width); 
        System.out.println(triangle);

      }
}