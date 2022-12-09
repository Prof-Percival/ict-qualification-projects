package vatiswa;

/**
 *
 * @author Christoph
 */
public class Vehicle {
    
    //Instance Variables
    private int wheels;
    protected String colour;
    private int seats;
    protected String model;
    private String transmission;
    
                    //Constructors
    //Default Constructor
    public Vehicle()
    {
        wheels = 0;
        colour = "";
        seats = 0;
        model = "";
        transmission = "";
    }
    
    //Constructor with Parameters
    public Vehicle(int wheel, String colour, int seats, String model, String transmission)
    {
        wheels = wheel;
        this.colour = colour;
        this.seats = seats;
        this.model = model;
        this.transmission = transmission;
    }
    
    
                    //Mutator Methods (Setters)
    //Method to set Wheels
    public void setWheels(int wheels)
    {
        this.wheels = wheels;
    }
    
    //Method to set Colour
    public void setColour(String colour)
    {
        this.colour = colour;
    }
    
    //Method to set Seats
    public void setSeats(int seats)
    {
        this.seats = seats;
    }
    
    //Method to set Model
    public void setModel(String model)
    {
        this.model = model;
    }
    
    //Method to set Transmission
    public void setTransmission(String transmission)
    {
        this.transmission = transmission;
    }
    
    
                    //Accessor Methods(Getters)
    //Method to return Wheels
    public int getWheels()
    {
        return wheels;
    }
    
    //Method to return Colour
    public String getColour()
    {
        return colour;
    }
    
    //Method to return Seats
    public int getSeats()
    {
        return seats;
    }
    
    //Method to return Model
    public String getModel()
    {
        return model;
    }
    
    //Method to return transmission
    public String getTransmission()
    {
        return transmission;
    }
    
    
    //toString() Method
   
    @Override
    public String toString()
    {
        return "Wheels: " + wheels + "\nColour: " + colour + "\nSeats: " + seats + "\nModel: " + model + "\nTransmission: " + transmission + "\n";
    }

}