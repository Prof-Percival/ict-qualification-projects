package ch3exercise13;

/**
 *
 * @author Christoph
 */

import java.util.Scanner;

public class TestLease {

    static Scanner input = new Scanner(System.in);
    
    public static void main(String[] args) {
        
        //Declaring Four Lease Object (Reference Variables)
        Lease lease1, lease2, lease3;
        
        //Object Holding default values
        Lease lease4 = new Lease();
        
        //Calling getData() method
        lease1 = TestLease.getData();
        lease2 = TestLease.getData();
        lease3 = TestLease.getData();
        
        //Calling showValues() Method
        TestLease.showValues(lease1);
        
        //Calling addPetFee() Method using lease1 object
        lease1.addPetFee();
        
        //Calling showValues() Method using lease1 Object
        TestLease.showValues(lease1);
        
        //Calling showValues() Method using lease2 Object
        TestLease.showValues(lease2);
        
        //Calling showValues() Method using lease3 Object
        TestLease.showValues(lease3);
        
        //Calling showValues() Method using lease4 Object
        TestLease.showValues(lease4);
    }
    
    
    //Method to get Data and create an Object
    public static Lease getData()
    {
        Lease temp = new Lease();
        
        String name;
        int aptNo, lease;
        double rent;
        
        //Taking Values from the user
        System.out.print("Input Tenant Name >> ");
        name = input.nextLine();
        System.out.print("Input Apartment Number >> ");
        aptNo = input.nextInt();
        System.out.print("Input Monthly Rent Amount >> ");
        rent = input.nextDouble();
        System.out.print("Input Term of The Lease (in Months) >> ");
        lease = input.nextInt();
        
        input.nextLine();
        
        System.out.println();
        
        //Setting values to instance variables
        temp.setTenantName(name);
        temp.setApartmentNumber(aptNo);
        temp.setRentAmount(rent);
        temp.setTermOfTheLease(lease);
        
        return temp;
    }
    
    //Method to Display Data
    public static void showValues(Lease obj)
    {
        System.out.println("Tenant Name: " + obj.getTenantName());
        System.out.println("Apartment Number: " + obj.getApartmentNumber());
        System.out.printf("Monthly Rent Amount = $%.2f%n", obj.getRentAmount());
        System.out.println("Term of The Lease = " + obj.getTermOfTheLease() + " Months\n");
    }
}