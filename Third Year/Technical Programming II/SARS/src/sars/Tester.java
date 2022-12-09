package sars;

/**
 *
 * @author Christoph
 */
import java.util.Scanner;

public class Tester {

    static Scanner input = new Scanner(System.in);
    public static void main(String[] args) {
        
        /* Customer customer = new Customer();
        
        customer.setCustomerId("8001015005084");
        customer.setCustomerId("1098002145");
        customer.setCustomerName("Christoph Percival");
        customer.setTypeOfAccount("Current Account");
        
        
        Bank bank = new Bank();
        
        bank.setBankNumber("77041");
        bank.setBankName("Standard Bank");
        bank.setBankDescription("Moving Forward");
        bank.setCustomer(customer);
        
        System.out.println(bank); 
        */

        Bank bank2 = new Bank();

        //Getting Bank Details
        System.out.print("\nInput Bank Number >> ");
        bank2.setBankNumber(input.nextLine());
        System.out.print("Input Bank Name >> ");
        bank2.setBankName(input.nextLine());
        System.out.print("Input Bank Description >> ");
        bank2.setBankDescription(input.nextLine());

        //Getting Customer Details
        System.out.print("Input Customer ID >> ");
        bank2.getCustomer().setCustomerId(input.nextLine());
        System.out.print("Input Customer Account Number >> ");
        bank2.getCustomer().setAccountNumber(input.nextLine());
        System.out.print("Input Customer Name >> ");
        bank2.getCustomer().setCustomerName(input.nextLine());
        System.out.print("Input Type of Account >> ");
        bank2.getCustomer().setTypeOfAccount(input.nextLine());

        System.out.println("\nCustomer Name: " + bank2.getCustomer().getCustomerName());
        
        System.out.println();

        System.out.println(bank2.toString());

        //
        Bank bank3 = new Bank();

        System.out.println();

        System.out.println(bank3);
        
    }   
}