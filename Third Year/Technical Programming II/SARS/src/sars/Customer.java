package sars;

/**
 *
 * @author Christoph
 */
public class Customer {
    
    //Instance Variables
    private String c_id; //Customer Id
    private String acc_no; //Customer Account No
    private String c_name; //Customer Name
    private String type_acc; //Type of Account
    
                    //Constructors
    //Default Constructor
    public Customer()
    {
        c_id = "";
        acc_no = "";
        c_name = "";
        type_acc = "";
    }

    //Constructor with Parameters
    public Customer(String c_id, String acc_no, String c_name, String type_acc) {
        this.c_id = c_id;
        this.acc_no = acc_no;
        this.c_name = c_name;
        this.type_acc = type_acc;
    }
    
    
                    //Mutator Methods (Setters)
    //Method to set Customer Id
    public void setCustomerId(String c_id)
    {
        this.c_id = c_id;
    }
    
    //Method to set Customer Account Number
    public void setAccountNumber(String acc_no)
    {
        this.acc_no = acc_no;
    }
    
    //Method to set Customer Name
    public void setCustomerName(String c_name)
    {
        this.c_name = c_name;
    }
    
    //Method to set Type of Account
    public void setTypeOfAccount(String type_acc)
    {
        this.type_acc = type_acc;
    }
    
    
                    //Accessor Methods(Getters)
    //Method to return Customer Id
    public String getCustomerId()
    {
        return c_id;
    }
    
    //Method to return Customer Account No
    public String getAccountNumber()
    {
        return acc_no;
    }
    
    
    //Method to return Customer Name
    public String getCustomerName()
    {
        return c_name;
    }
    
    //Method to return Type of Account
    public String getTypeOfAccount()
    {
        return type_acc;
    }
    
    
                    //Other Methods
    //toString() Method
    @Override
    public String toString()
    {
        return "Customer Id: " + c_id + "\nAccount Number: " + acc_no + "\nCustomer Name: " + c_name + "\nType of Account: " + type_acc + "\n";
    } 
}