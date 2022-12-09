package ch5_example20;

import java.io.FileReader;
import java.util.Scanner;
import java.io.FileNotFoundException;

public class Ch5_Example20 {

    public static void main(String[] args) throws FileNotFoundException {
        
        Scanner inFile = new Scanner (new FileReader("Exp_5_20.txt"));
        
        int num, sum, p;
        
        for (p = 1; p <=4; p++){
            sum = 0; 
            num = inFile.nextInt();
            while (num != -999) {
                sum += num;
                num = inFile.nextInt();
            }
            System.out.println("Line " + p +": Sum = " + sum);
        }
        inFile.close();
    }
}