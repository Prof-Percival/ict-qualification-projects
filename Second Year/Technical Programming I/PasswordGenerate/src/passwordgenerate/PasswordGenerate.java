package passwordgenerate;
import java.util.*;
  
public class PasswordGenerate {
    public static void main(String[] args)
    {
        // Length of your password as I have choose here to be 10
        int length = 10;
        System.out.print("Your New Password is : " );
        System.out.println(gen_Password(length));
    }
    
    // This is Password generating method
    // I have used static here, so that I do not to make any object for it
    static char[] gen_Password(int len)
    {
        
  
        // A strong password has Cap_chars, Lower_chars, numeric value and symbols. So I'm using all of them to generate a password
        String Capital_chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        String Small_chars = "abcdefghijklmnopqrstuvwxyz";
        String numbers = "0123456789";
        String symbols = "!@#$%^&*_=+-/.?<>)";
  
        String values = Capital_chars + Small_chars + numbers + symbols;
  
        // Using random method
        Random rndm_method = new Random();
  
        char[] password = new char[len];
  
        for (int i = 0; i < len; i++)
        {
            // Use of charAt() method : to get character value
            // Use of nextInt() as it is scanning the value as int
            password[i] =
              values.charAt(rndm_method.nextInt(values.length())); 
        }
        return password;
    }
}