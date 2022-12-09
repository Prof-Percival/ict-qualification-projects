package sars;

/**
 *
 * @author Christoph
 */
public class Bank {
 
    //Instance Variables
    private String b_no; //Bank Number
    private String b_name; //Bank Name
    private String desc; //Bank Description
    private Customer cust; //Customer
    
                    //Constructors
    //Default Constructor
    public Bank()
    {
        b_no = "";
        b_name = "";
        desc = "";
        cust = new Customer();
    }
    
    //Constructor with Parameters
    public Bank(String no, String name, String desc, Customer cust)
    {
        this.b_no = no;
        this.b_name = name;
        this.desc = desc;
        this.cust = cust;
    }
    
    //Constructor with Parameters
    public Bank(String no, String name, String desc, String id, String acc_no, String c_name, String type)
    {
        this.b_no = no;
        this.b_name = name;
        this.desc = desc;
        cust = new Customer(id, acc_no, c_name, type);
    }
    
    
                    //Mutator Methods
    //Method to set Bank Number
    public void setBankNumber(String no)
    {
        this.b_no = no;
    }
    
    //Method to set Bank Name
    public void setBankName(String name)
    {
        this.b_name = name;
    }
    
    //Method to set Bank Description
    public void setBankDescription(String desc)
    {
        this.desc = desc;
    }
    
    //Method to set Customer object
    public void setCustomer(Customer cust)
    {
        this.cust = cust;
    }
    
    
                    //Accessor Methods(Getters)
    //Method to return Bank Number
    public String getBankNumber()
    {
        return b_no;
    }
    
    //Method to return Bank Name
    public String getBankName()
    {
        return b_name;
    }
    
    //Method to return Bank Description
    public String getBankDescription()
    {
        return desc;
    }
    
    //Method to return Customer object
    public Customer getCustomer()
    {
        return cust;
    }
    
    
                    //Other Methods
    //Method to return (Calculate) Service Charge
    public int calculateServiceCharge()
    {
        switch (cust.getTypeOfAccount())
        {
            case "Savings Account":
                return 20;
            case "Current Account":
                return 100;
            default:
                return 0;
        }
    }
    
    //toString() Method
    @Override
    public String toString()
    {
        return "Bank Number: " + b_no + "\nBank Name: " + b_name + "\nBank Description: " + desc + "\n" + cust.toString() + 
                String.format("Service Charge: R%.2f per Month%n", (double) calculateServiceCharge());
    }
}