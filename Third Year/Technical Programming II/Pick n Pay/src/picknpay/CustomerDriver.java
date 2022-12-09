package picknpay;

/**
 *
 * @author Christoph
 */
public class CustomerDriver {

    public static void main(String[] args) {
        
        Account account = new Account();
        
        account.setAccountId("109844901");
        account.setType("Savings");
        account.setPoints(781);
        account.setDateOfRegistration("17/05/2022");
        
        Customer customer = new Customer("Christoph Percival", "321 Jorissen Street", "0634647813", account);
        
        System.out.println(customer);
    }   
}