package c9e1_alpha;

/**
 *
 * @author Christoph
 */
public class C9E1_Alpha {

    
    public static void main(String[] args) {
        
        double[] alpha = new double[50];
        
        for (int i = 0; i < alpha.length; i++)
        {
            if (i < 25)
            {
                alpha[i] = i * i;
            }
            else
            {
                alpha[i] = i * i * i;
            }
        }
        
        int counter = 1;
        
        for (double i: alpha)
        {
            System.out.printf("%-10.1f ",i);
            
            if (counter == 10)
            {
                System.out.println();
                
                counter = 0;
            }
            
            counter++;   
        }
    }   
}