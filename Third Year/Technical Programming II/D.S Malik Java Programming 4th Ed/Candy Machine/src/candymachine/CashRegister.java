package candymachine;

public class CashRegister {
	
    private int cashOnHand; //Variable to hold cash

    //Default Constructor
    public CashRegister()
    {
        cashOnHand = 500;
    }

    //Constructor with parameter
    public CashRegister(int cashIn)
    {   
        if (cashIn >= 0)
            cashOnHand = cashIn;
        else
            cashOnHand = 500;
    }
    
    
                            //Methods
    //Method to show current amount in the cash register
    public int currentBalance()
    {
        return cashOnHand;
    }
    
    //Method to receive amount deposited by the customer
    public void acceptAmount(int amountIn)
    {
        cashOnHand += amountIn;
    }
    
}