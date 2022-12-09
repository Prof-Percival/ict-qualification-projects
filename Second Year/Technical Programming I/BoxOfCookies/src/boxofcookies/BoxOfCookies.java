package boxofcookies;

import java.util.Scanner;

public class BoxOfCookies {
    
    public static void main(String[] args) {
        
        Scanner inFile = new Scanner(System.in);
        
        int cookies, boxes, containers, leftoverCookies, leftoverBoxes;
        
        System.out.print("Input Total Number of Cookies >> ");
        cookies = inFile.nextInt();
        
        //Calculating Number of Boxex to hold the Cookies
        boxes = cookies / 24;
        
        //Calculating Number of Containers To Hold The Boxes of Cookies
        containers = boxes / 75;
        
        //Calculating Leftover Cookies
        leftoverCookies = cookies % 24;
        
        //Calculating Leftover Boxes
        leftoverBoxes = boxes % 75;
        
        System.out.println("\n\n\t\t\t*******Box of Cookies*******");
        System.out.println("Number of Boxes = " + boxes);
        System.out.println("Number of Containers To Ship The Cookies = " + containers);
        System.out.println("Number of Left-Over Cookies = " + leftoverCookies);
        System.out.println("Number of Left-Over Boxes = " + leftoverBoxes);
        System.out.println("\n");
    }   
}