package bank;

/**
 *
 * @author Christoph
 */
public abstract class BankAccount {
 
    //Instance Variables
    protected int accountNumber;
    protected String name;
    protected double balance;
    
                    //Constructors
    //Default Constructor
    public BankAccount()
    {
        accountNumber = 0;
        name = "";
        balance = 0.0;
    }
    
    //Constructor with Parameters
    public BankAccount(String name, int accountNumber, double balance)
    {
        this.name = name;
        this.accountNumber = accountNumber;
        this.balance = balance;
    }
    
                    //Mutator Methods (Setters)
    //Method to set Name
    public void setName(String name)
    {
        this.name = name;
    }
    
    
                    //Accessor Methods (Getters)
    //Method to return Account Number
    public int getAccountNumber()
    {
        return accountNumber;
    }
    
    //Method to return Name
    public String getName()
    {
        return name;
    }
    
    //Method to return Balance
    public double getBalance()
    {
        return balance;
    }
    
    
                    //Other Methods
    //Method to Withdraw Money
    public void withdraw(double moneyToWithdraw)
    {
        balance -= moneyToWithdraw;
    }
    
    //Method to Deposit Money
    public void deposit(double moneyToDeposit)
    {
        balance += moneyToDeposit;
    }
    
    //Abstract Method to Create Monthly Statement
    public abstract void createMonthlyStatement();
    
    //Method to override toString() method
    @Override
    public String toString()
    {
        return "Customer Name: " + name + "\nAccount Number: " + accountNumber + String.format("%nBalance: R%.2f%n",balance);
    }
}