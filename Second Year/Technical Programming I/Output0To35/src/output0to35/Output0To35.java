package output0to35;

import java.util.Scanner;

public class Output0To35 {

    public static void main(String[] args) {
        
        Scanner inFile = new Scanner(System.in);
        
        System.out.print("Input an Integer Between 0 & 35 >> ");
        int number = inFile.nextInt();
        System.out.println();
        
        if (number >= 0 && number <= 35){
            if (number <= 9 )
                System.out.println(number + " Turns To " + number + "\n");
            else if (number >= 10)
                System.out.println(number + " Turns To " + (char)(55 + number) + "\n");
        } else
            System.out.println("Input Must Be Between 0 And 35\n");
    }   
}