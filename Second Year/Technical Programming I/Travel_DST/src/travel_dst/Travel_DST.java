package travel_dst;

import java.util.Scanner;
import java.io.FileReader;
import java.io.PrintWriter;
import java.io.FileNotFoundException;

public class Travel_DST {

    public static void main(String[] args) throws FileNotFoundException {
        
        Scanner infile = new Scanner(new FileReader("dataTravel.txt"));
        PrintWriter outfile = new PrintWriter("travel.txt"); //Opening the (travel.txt) file 
        
        double distance, speed, travelTime;
        
        //Assigning first value in file to distance
        distance = infile.nextDouble();
        
        //Assigning second value in file to speed
        speed = infile.nextDouble();
        
        //Calculating travelled time and storing it in travelTime
        travelTime = distance / speed;
        
        //Writing values to (travel.txt) file
        outfile.printf("Distance = %.2fkm%n", distance);
        outfile.printf("Speed = %.2fkm/h%n", speed);
        outfile.printf("Time = %.3fh%n", travelTime);
        
        //Closing out files
        infile.close();
        outfile.close();
    }
    
}