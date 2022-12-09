package cardealer;

import java.util.Scanner;
import java.io.FileReader;
import java.io.FileNotFoundException;

public class CarDealer {
    
    public static void main(String[] args) throws FileNotFoundException{
        
        Scanner input = new Scanner(new FileReader("CarsSold.txt"));
        
        String employeeNo, highestEmployee = "";
        short carsSold = 0, totalCarsSold = 0, highestCars = 0;
        
        while (input.hasNext()){
            employeeNo = input.next();
            carsSold = input.nextShort();
            
            totalCarsSold += carsSold;
            
            if (highestCars < carsSold){
                highestCars = carsSold;
                highestEmployee = employeeNo;
            }     
        }
        System.out.println("Total Cars Sold = " + totalCarsSold);
        System.out.println("Salesperson That Sold Highest Cars: " + highestEmployee);
        input.close();
    }   
}