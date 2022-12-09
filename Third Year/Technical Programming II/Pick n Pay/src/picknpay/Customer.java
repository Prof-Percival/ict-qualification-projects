package picknpay;

/**
 *
 * @author Christoph
 */
public class Customer {
 
    //Instance Variables
    private String name;
    private String address;
    private String telephone;
    private Account account;
    
                    //Constructors
    //Default Constructor
    public Customer()
    {
        name = "";
        address = "";
        telephone = "";
        account = new Account();
    }
    
    //Constructor with Parameters
    public Customer(String name, String address, String telephone)
    {
        this.name = name;
        this.address = address;
        this.telephone = telephone;
        account = new Account();
    }
    
    //Constructor with Parameters
    public Customer(String name, String address, String telephone, Account account)
    {
        this.name = name;
        this.address = address;
        this.telephone = telephone;
        this.account = account;
    }
    
    //Constructor with Parameters
    public Customer(String name, String address, String telephone, String accountId, String type, int points, String date)
    {
        this.name = name;
        this.address = address;
        this.telephone = telephone;
        account = new Account(accountId, type, points, date);
    }
    
                        //Mutator Methods (Setters)
    //Method to set Name
    public void setName(String name)
    {
        this.name = name;
    }
    
    //Method to set Address
    public void setAddress(String address)
    {
        this.address = address;
    }
    
    //Method to set Telephone
    public void setTelephone(String telephone)
    {
        this.telephone = telephone;
    }
    
    //Method to set reference address for account object
    public void setAccount(Account account)
    {
        this.account = account;
    }
    
                    //Accessor Methods (Getters)
    //Method to return Name
    public String getName()
    {
        return name;
    }
    
    //Method to return Address
    public String getAddress()
    {
        return address;
    }
    
    //Method to return Telephone
    public String getTelephone()
    {
        return telephone;
    }
    
    //Method to return reference address for account object
    public Account getAccount()
    {
        return account;
    }
    
                    //Other Methods
    //Method to Calculate Discounted Amount
    public int calculateDiscountAmount()
    {
        if (account.getPoints() < 500)
            return 0;
        else 
            if (account.getPoints() >= 500 && account.getPoints() <= 1000)
                return 50;
        else
            return 100;
    }
    
    
    //toString Method
    @Override
    public String toString()
    {
        return "Name: " + name + "\nAddress: " + address + "\nTelephone: " + telephone + "\n" + account.toString() + 
                String.format("Discount Amount: R%.2f%n", (double) calculateDiscountAmount());
                
    }
    
}