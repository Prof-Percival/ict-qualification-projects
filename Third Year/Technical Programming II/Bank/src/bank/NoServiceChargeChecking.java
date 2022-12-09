package bank;

/**
 *
 * @author Christoph
 */
public class NoServiceChargeChecking extends CheckingAccount {
    
    private static final double MIN_BALANCE = 1000.0;
    private static final double INTEREST_RATE = 0.02;
    protected double minimumBalance;
    protected double interestRate;
    
                    //Constructors
    public NoServiceChargeChecking(String name, int accountNumber, double balance)
    {
        super(name, accountNumber, balance);
        minimumBalance = 0.0;
        interestRate = 0.0;
    }
    
    public NoServiceChargeChecking(String name, int accountNumber, double balance, double minimumBalance, double interestRate)
    {
        super(name, accountNumber, balance);
        this.minimumBalance = minimumBalance;
        this.interestRate = interestRate;
    }
    
    //Metthod to set Minimum Balance
    public void setMinimumBalance(double minimumBalance)
    {
        this.minimumBalance = minimumBalance;
    }
    
    //Method to return Minimum Balance
    public double getMinimumBalance()
    {
        return minimumBalance;
    }
    
    //Method to verify Minimum Balance
    public boolean verifyMinimumBalance(double balance)
    {
        if (MIN_BALANCE == balance)
            return true;
        else
            return false;
    }
    
    //Method to write Check
    @Override
    public void writeCheck(double money)
    {
        
    }
    
    //Method to withdraw
    public void withdraw(double amountToWithdraw)
    {
        balance -= amountToWithdraw;
    }

    @Override
    public void createMonthlyStatement() {
        
    }
    
    //toString() Method
    public String toString()
    {
        return super.toString();
    }

}