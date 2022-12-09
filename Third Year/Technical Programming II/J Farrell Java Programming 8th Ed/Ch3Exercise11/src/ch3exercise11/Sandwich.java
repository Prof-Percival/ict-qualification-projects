package ch3exercise11;

/**
 *
 * @author Christoph
 */
public class Sandwich {
 
    //Data fields
    private String mainIngredient;
    private String breadType;
    private double price; 
    
    //Default Constructor
    public Sandwich()
    {
        mainIngredient = "";
        breadType = "";
        price = 0.0;
    }
    
    //Constructor with Parameters
    public Sandwich(String mainIngredient, String breadType, double price)
    {
        this.mainIngredient = mainIngredient;
        this.breadType = breadType;
        this.price = price;
    }
    
                    //Mutator Methods
    //Method to Set Main Ingredient
    public void setMainIngredient(String ingredient)
    {
        this.mainIngredient = ingredient;
    }
    
    //Method to Set Bread Type
    public void setBreadType(String bread)
    {
        this.breadType = bread;
    }
    
    //Method to Set Price
    public void setPrice(double price)
    {
        this.price = price;
    }
    
                    //Accessor Methods
    //Method to get Main ingredient
    public String getMainIngredient()
    {
        return mainIngredient;
    }
    
    //Method to get Bread Type
    public String getBreadType()
    {
        return breadType;
    }
    
    //Method to get Price
    public double getPrice()
    {
        return price;
    }
    
    //Override toString() method
    @Override
    public String toString()
    {
        return "Main Ingredient: " + mainIngredient + "\nBread Type: " + breadType + "\nPrice: $" + price;
    }
}