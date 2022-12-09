package elapsed_time;

import java.util.*;
import java.lang.*;

public class Elapsed_Time {
    
    static Scanner console = new Scanner(System.in);
    
    public static void main(String[] args) {
       
        //Declaration of Primitive Variables 
       int Seconds, hours, minutes = 0, remSeconds;
       double Hours, Minutes = 0.0, seconds, secondsAH;
       
       //Declaration & Initialization of Referencing Variables
       String HH = "", MM = "", SS = "";
       
       //Getting Data from the user
       System.out.print("Input The Elapsed Time For an Event in Seconds >> ");
       seconds = console.nextDouble();
       
       //Converting Seconds to Hours (in Integral)
       hours = (int)(seconds / 60 / 60); //>>>>>>>>>>>>>>>>>
       
       //Testing Display 1   System.out.println("Seconds: " + hours);
       
       //Hours = ("0") + hours;
       //Converting Seconds to Hours in Floating-point
       Hours = (seconds / 60 / 60); 
       
       //Testing Display 2   System.out.println("Seconds: " + Hours);
       
       //Remaining Seconds After Hours 
       secondsAH = Math.ceil((Hours - hours) * 60  * 60);
       
       //Testing Display 3   System.out.println("Seconds:3 " + secondsAH);
       
       if (secondsAH < 60.0){
       //Minutes Calculations
       minutes = 0;  //>>>>>>>>>>>>>>>>>>>>>>
       
       // Testing Display 4  System.out.println("Seconds:4 " + minutes);
       
       //Converting seconds to Minutes in Floating-point
       Minutes = secondsAH;
       
       //Testing Display 5   System.out.println("Seconds:5 " + Minutes);
       
        }else if (secondsAH >= 60.0){
            
            minutes = (int) (secondsAH / 60);
            
            Minutes = secondsAH % 60;
        }
       //Finding the remaining seconds after minutes
       remSeconds = (int) (Minutes);   //>>>>>>>>>>>>>>>>>>>       
       
       //Selection Structure For Hours
       if (hours >= 0 && hours < 10){
               HH = "0" + hours;
       }else if (hours >= 10){
           HH = "" + hours;
       }
       
       //Selection Structure for Minutes
       if (minutes >= 0 && minutes < 10){
           MM = "0" + minutes;
       }else if (minutes >= 10){
           MM = "" + minutes;
       }
       
       //Selection Structure for Seconds
      if (remSeconds >= 0 && remSeconds < 10){
           SS = "0" + remSeconds;
       }else if (remSeconds >= 10){
           SS = "" + remSeconds;
       }
       
       System.out.println("\n");
       
       //Displaying Elapsed Hours
       System.out.println("\t\t\t Elapsed Time");
       System.out.println("Hours: " + hours);
       System.out.println("Minutes: " + minutes);
       System.out.println("Seconds: " + remSeconds);
       System.out.println("\t\t\t [ " + HH + ":" + MM + ":" + SS + " ]" +"\n");
       System.out.println();
              
    }   
}