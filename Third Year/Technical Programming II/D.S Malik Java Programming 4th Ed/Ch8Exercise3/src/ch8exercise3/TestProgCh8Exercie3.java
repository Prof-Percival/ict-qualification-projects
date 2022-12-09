package ch8exercise3;

import java.util.Scanner;

public class TestProgCh8Exercie3 {

	static Scanner input = new Scanner(System.in);
	
	public static void main(String[] args) {
	
		Day obj = new Day();
		
		System.out.println("Day: " + obj.getDay());
		System.out.println("Details of Object (toSring) " + obj);
		obj.setDay(11);
		obj.printDay();
		System.out.println("Previous Day: " + obj.getPreviousDay());
		System.out.println("Next Day: " + obj.getNextDay());
		System.out.println("Next Day: " + obj.getNextDay());
		System.out.println("Next Day: " + obj.getNextDay());
		System.out.println("Next Day: " + obj.getNextDay());
		System.out.println("Next Day: " + obj.getNextDay());
		System.out.println("Next Day: " + obj.getNextDay());
		System.out.println("Previous Day: " + obj.getPreviousDay());
		System.out.println("Previous Day: " + obj.getPreviousDay());
		System.out.println("Previous Day: " + obj.getPreviousDay());
		obj.setDay(1);
		obj.printDay();
		obj.addDaysToCurrentDays(4);
		obj.setDay(2);
		obj.printDay();
		obj.addDaysToCurrentDays(13);
		System.out.println();

	}
}