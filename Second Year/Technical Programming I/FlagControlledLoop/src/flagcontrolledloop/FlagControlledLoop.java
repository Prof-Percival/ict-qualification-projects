package flagcontrolledloop;

import java.util.*;

public class FlagControlledLoop {
    
    static Scanner console = new Scanner(System.in);

    public static void main(String[] args) {

        //declare the variables
        int num; //variable to store the random number
        int guess; //variable to store the number

        //guessed by the user
        boolean done; //boolean variable to control the loop
        num = (int) (Math.random() * 100); 
        done = false;

        while (!done) {

            System.out.print ("Enter An Integer Greater Than or Equal To 0 and Less Than 100: ");
            guess = console.nextInt();

            System.out.println();

            if (guess == num) {
                System.out.println("You Guessed The Correct Number.\n");
                done = true;
            } else if (guess < num)
                System.out.println("Your Guess Is Lower Than The Number.\nGuess Again!\n");
            else
                System.out.println("Your Guess Is Higher Than The Number.\nGuess Again!\n");
        } //end while
    } 
}