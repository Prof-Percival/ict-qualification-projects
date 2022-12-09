package vatiswa;

/**
 *
 * @author Christoph
 */
public class Bus extends Vehicle {
    
    //Instance Variables
    private int doors;
    private int maxSpeed;
    
                    //Constructors
    //Default Constructor
    public Bus()
    {
        super();
        doors = 0;
        maxSpeed = 0;
        
    }
    
    //Constructor with Parameters
    public Bus(int wheels, String colour, int seats, String model, String transmission, int doors, int maxSpeed)
    {
        super(wheels, colour, seats, model, transmission);
        this.doors = doors;
        this.maxSpeed = maxSpeed;
    }
    
    
                    //Mutator Methods(Setters)
    //Method to set Doors
    public void setDoors(int doors)
    {
        this.doors = doors;
    }
    
    //Method to set Max Speed
    public void setMaxSpeed(int maxSpeed)
    {
        this.maxSpeed = maxSpeed;
    }
    
    
                    //Accessor Methods(Getters)
    //Method to return Doors
    public int getDoors()
    {
        return doors;
    }
    
    //Method to return Max Speed
    public int getMaxSpeed()
    {
        return maxSpeed;
    }
    
    @Override
    public String toString()
    {
        return super.toString()  + "Doors: " + doors + "\nMax Speed: " + maxSpeed + "km/h\n";
    }
    
    
}