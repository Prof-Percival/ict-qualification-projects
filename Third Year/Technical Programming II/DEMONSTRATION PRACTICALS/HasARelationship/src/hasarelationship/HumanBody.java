package hasarelationship;

/**
 *
 * @author Christoph
 */
public class HumanBody {
 
    //Instance Variables
    private int legs;
    private String colour;
    private double height;
    private double mass;
    private Heart heart;
    
                    //Constructors
    //Default Constructor
    public HumanBody()
    {
        legs = 2;
        colour = "Black";
        height = 0.0;
        mass = 0.0;
        heart = new Heart();
    }
    
    //Constructor with Parameters
    public HumanBody(int legs, String colour, double height, double mass, Heart heart)
    {
        this.legs = legs;
        this.colour = colour;
        this.height = height;
        this.mass = mass;
        this.heart = heart;
    }

    
                    //Mutator Methods(Setters)
    //Method to set Legs
    public void setLegs(int legs)
    {
        this.legs = legs;
    }

    //Method to set Colour
    public void setColour(String colour)
    {
        this.colour = colour;
    }

    //Method to set Height
    public void setHeight(double height)
    {
        this.height = height;
    }

    //Method to set Mass
    public void setMass(double mass)
    {
        this.mass = mass;
    }

    //Method to set Heart
    public void setHeart(Heart heart)
    {
        this.heart = heart;
    }
    
    
                    //Accessor Methods(Getters)
    //Method to return Legs
    public int getLegs()
    {
        return legs;
    }

    //Method to return Colour
    public String getColour()
    {
        return colour;
    }

    //Method to return Height
    public double getHeight()
    {
        return height;
    }

    //Method to return Mass
    public double getMass()
    {
        return mass;
    }

    //Method to return Heart
    public Heart getHeart()
    {
        return heart;
    }
    
    private double calculateBMI()
    {
        return mass / height;
    }

    
    @Override
    public String toString()
    {
        return "Legs: " + legs + "\nColour: " + colour + "\nHeight: " + height + "\nMass: " + mass + "\n"+ heart.toString() + "BMI: " + calculateBMI();
    }
}