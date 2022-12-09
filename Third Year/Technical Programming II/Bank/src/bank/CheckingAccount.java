package bank;

/**
 *
 * @author Christoph
 */
public abstract class CheckingAccount extends BankAccount {
 
    //Default Constrcutor
    public CheckingAccount()
    {
        super(); //Calling Constructor of Superclass (BankAccount)
    }
    
    //Constructor with Parameters
    public CheckingAccount(String name, int accountNumber, double balance)
    {
        super(name, accountNumber, balance); //Calling & Passing arguments to Constructor of Superclass (BankAccount) to initialize instance variables
    }
    
    //Abstract Method to Write Check
    public abstract void writeCheck(double amount);
    
    
}