package candymachine;

public class Dispenser {
    
    private int numberOfItems; //Variable to store number of items in the Dispenser
    private int cost; //Variable to store cost of an item
    
                            //Constructors
    //Default constructor
    public Dispenser()
    {
        numberOfItems = 50;
        cost = 50;
    }
    
    //Constructor with parameters
    public Dispenser(int setNoOfItems, int setCost)
    {
        if (setNoOfItems >= 0)
            numberOfItems = setNoOfItems;
        else
            numberOfItems = 50;
        
        if (setCost >= 0)
            cost = setCost;
        else
            cost = 50;
    }
    
    
                                //Methods
    //Method to return number of items in Dispenser
    public int getCount()
    {
        return numberOfItems;
    }
    
    //Method to return cost of item
    public int getProductCost()
    {
        return cost;
    }
    
    //Method to decrement number of items
    public void makeSale()
    {
        numberOfItems --;
    }
    
}