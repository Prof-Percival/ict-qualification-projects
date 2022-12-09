package nationalweatherservices;

import java.util.Scanner;

public class NationalWeatherServices {

    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);
        
        short cloudPerc, counter = 1;
        
        while (counter <= 7){
            System.out.print("Input Percentage of Cloud Cover >> ");
            cloudPerc = input.nextShort();
            
            if (cloudPerc >= 0 && cloudPerc <= 100) {
                if (cloudPerc >= 0 && cloudPerc <= 30)
                    System.out.println("\nDegree of Cloudiness: Clear\n");
                else
                    if (cloudPerc >= 31 && cloudPerc <= 70)
                        System.out.println("\nDegree of Cloudiness: Partly Cloudy\n");
                else
                    if (cloudPerc >= 71 && cloudPerc <= 99)
                        System.out.println("\nDegree of Cloudiness: Cloudy\n");
                else
                    if (cloudPerc == 100)
                        System.out.println("\nDegree of Cloudiness: Overcast\n");
                
                //Increment The Counter
                counter += 1;
                
            }else
                System.out.println("\nPercentage of Cloud Cover Must Be Between 0% And 100%\n");
        }
    }   
}