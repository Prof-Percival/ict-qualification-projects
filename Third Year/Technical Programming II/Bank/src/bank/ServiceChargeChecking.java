package bank;

/**
 *
 * @author Christoph
 */
public class ServiceChargeChecking extends CheckingAccount {
    
    //Private Static Constant Data Members
    private static final double ACCOUNT_SERVICE_CHARGE = 10.0;
    private static final int MAXIMUM_NUM_OF_CHECKS = 5;
    private static final double SERVICE_CHARGE_EXCESS_NUM_OF_CHECKS = 5.0;
    
    //Instance Variables
    protected double serviceChargeAccount;
    protected double serviceChargeCheck;
    protected int numberOfChecksWritten;

    
    //Constructor to Call Superclass CheckingAccount which calls other Superclass (BankAccount)
    public ServiceChargeChecking(String name, int accountNumber, double balance)
    {
        super(name, accountNumber, balance);
        this.serviceChargeAccount = 0.0;
        this.serviceChargeCheck = 0.0;
        this.numberOfChecksWritten = 0;
    }
    
    //Constructor to Initialize instance variables and Call Superclass CheckingAccount which calls other Superclass (BankAccount)
    public ServiceChargeChecking(String name, int accountNumber, double balance, double serviceChargeAccount, double serviceChargeCheck)
    {
        super(name, accountNumber, balance); //Calling & Passing arguments to Constructor of Superclass (CheckingAccount)  to call Superclass (BankAccount) to initialize instance variables
        
        //Initializing Instance variables of ServiceChargeChecking Class
        this.serviceChargeAccount = serviceChargeAccount;
        this.serviceChargeCheck = serviceChargeCheck;
        this.numberOfChecksWritten = 0;
    }
    
                    //Mutator Methods (Setters)
    //Method to set Service Charge Account
    public void setServiceChargeAccount(double sca)
    {
        this.serviceChargeAccount = sca;
    }
    
    //Method to set Service Charge Checks
    public void setServiceChargeChecks(double scc)
    {
        this.serviceChargeCheck = scc;
    }
    
    //Method to set Number of Checks Written
    public void setNumberOfChecksWritten(int nocw)
    {
        this.numberOfChecksWritten = nocw;
    }
    
    
                    //Accessor Methods(Getters)
    //Method to return Service Charge Account
    public double getServiceChargeAccount()
    {
        return serviceChargeAccount;
    }
    
    //Method to return Service Charge Checks
    public double getServiceChargeChecks()
    {
        return serviceChargeCheck;
    }
    
    //Method to return Number of Checks Written
    public int getNumberOfChecksWritten()
    {
        return numberOfChecksWritten;
    }
    
    
                    //Other Methods
    //Method to Post Service Charge
    public void postServiceCheck()
    {
        
    }
    
    //Method to Override Write Checks
    @Override
    public void writeCheck(double amount)
    {
        
    }
    
    //Method to Create Monthly Statement
    @Override
    public void createMonthlyStatement()
    {
        
    }
    
    //toString() method
    @Override
    public String toString()
    {
        return super.toString() + "\nService Charge Account: " + serviceChargeAccount + "\nService Charge Checks: " + serviceChargeCheck + "\nNumber of Checks Written: " + numberOfChecksWritten;
    }
    
}