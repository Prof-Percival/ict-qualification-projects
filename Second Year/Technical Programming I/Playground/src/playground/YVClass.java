
package playground;

import static playground.Playground.*;
import static playground.Playground.input;

public class YVClass {
    
    public  void test(){
    
        System.out.print("Input Base >> ");
        double ba = input.nextDouble();
        System.out.print("Input an Exponent of Integer >> ");
        int ex = input.nextInt();
        
        System.out.println("vyPow of 7: " + vyPow(ba, ex));
        System.out.println("Execution from YVClas");
    
    }
            
}
