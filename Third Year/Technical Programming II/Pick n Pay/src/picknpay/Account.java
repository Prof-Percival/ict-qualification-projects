package picknpay;

/**
 *
 * @author Christoph
 */

public class Account {
    
    //Instance Variables
    private String accountId;
    private String type;
    private int points;
    private String date;
    
    
                    //Constructors
    //Default Constructor
    public Account()
    {
        accountId = "";
        type = "";
        points = 0;
        date = "17/05/2022"; //DD/MM/YYYY
    }
    
    //Constructor with Parameters
    public Account(String accountId, String type, int points, String date)
    {
        this.accountId  = accountId;
        this.type = type;
        this.points = points;
        this.date = date;
    }
    
    
                    //Mutator Methods (Setters)
    //Method to set Account Id
    public void setAccountId(String accountId)
    {
        this.accountId = accountId;
    }
    
    //Method to set Account Type
    public void setType(String type)
    {
        this.type = type;
    }
    
    //Method to set Points
    public void setPoints(int points)
    {
        this.points = points;
    }
    
    //Method to set Date of Registration
    public void setDateOfRegistration(String date)
    {
        this.date = date;
    }
    
    
                    //Accessor Methods(Getters)
    //Method to return Account Id
    public String getAccountId()
    {
        return accountId;
    }
    
    //Method to return Account Type
    public String getType()
    {
        return type;
    }
    
    //Method to return Points
    public int getPoints()
    {
        return points;
    }
    
    //Method to return Date of Registration
    public String getDateOfRegistration()
    {
        return date;
    }
    
    //toString() Method
    @Override
    public String toString()
    {
        return "Account Id: " + accountId + "\nAccount Type: " + type + "\nPoints: " + points + "\nDate of Registration: " + date + "\n";
    }
}