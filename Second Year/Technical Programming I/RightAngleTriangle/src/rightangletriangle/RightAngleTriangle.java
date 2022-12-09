package rightangletriangle;

import java.util.Scanner;

public class RightAngleTriangle {

    public static void main(String[] args) {
        
        Scanner inFile = new Scanner(System.in);
        
        double h, o, a; //H - Hypotenuse SIde, O - Opposite Side, A - Adjacent Side
        
        System.out.print("Input The Lengths of Three Sides of a Triangle (Large To Small) >> ");
        h = inFile.nextDouble();
        o = inFile.nextDouble();
        a = inFile.nextDouble();
        
        if ((Math.pow(h, 2.0)) == (Math.pow(o, 2.0)) + (Math.pow(a, 2.0)))
            //if ((h * h) == ((a * a) + (o * o)))
            System.out.println("This is a Right Angle Triangle\n");
        else
            System.out.println("This is NOT a Right Angle Trangle\n");
    }
    
}
