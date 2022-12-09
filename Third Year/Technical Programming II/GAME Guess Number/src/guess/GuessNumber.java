package guess;

import java.util.Random;
import java.util.Scanner;

public class GuessNumber {

	public static void main(String[] args) 
	{
		Scanner input = new Scanner(System.in);
		
		Random random = new Random();
		
		System.out.println("Welcome To The Guess Number Game");
		
		System.out.print("Input Your Name >> ");
		String name = input.nextLine();
		
		System.out.println("\nHello " + name);
		System.out.print("\nShould The Game Begin (Y / N): ");
		
		if (input.nextLine().toUpperCase().equals("Y")) 
		{
			int randomNumber = random.nextInt(101);
			
			int guessedNumber = 0;
			for (int i = 0; i < 5; i++) 
			{
				System.out.print("Input Your Guessed Number (0 - 100) >> ");
				guessedNumber = input.nextInt();
				
				if (guessedNumber == randomNumber) 
				{
					System.out.println("\n Congratulations!!! You Guessed The Number...");
					System.out.printf("\nThe Number is [ %d ]",randomNumber);
					break;
				}
				else
					if (guessedNumber > randomNumber) 
					{
						System.out.println("\nYou Guessed Higher");
					}
					else
					{
						System.out.println("\nYou Guessed Lower");
					}
				
				if (i == 4) 
				{
					System.out.println("\nGAME OVER!");
					System.out.printf("\nThe Number is [ %d ]",randomNumber);
					break;
				}
				
				System.out.println("\nTry Guessing Again...\n");
			}
		}
		else 
		{
			System.out.println("Game Did Not Start...");
			System.out.println("To Start The Game, Re-run the App");
		}
	}
}
