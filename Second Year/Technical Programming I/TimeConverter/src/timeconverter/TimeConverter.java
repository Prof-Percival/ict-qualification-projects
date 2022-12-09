package timeconverter;

import java.util.Scanner;

public class TimeConverter {
    
    public static void main(String[] args) {
        
        Scanner scanner = new Scanner(System.in);
        int hours = 24, minutes = 60, seconds = 60;
        int days = scanner.nextInt();
        System.out.println(days * hours * minutes * seconds);
        
    }   
}