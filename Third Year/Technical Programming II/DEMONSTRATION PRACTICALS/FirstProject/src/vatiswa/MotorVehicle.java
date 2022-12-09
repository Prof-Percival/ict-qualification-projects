package vatiswa;

/**
 *
 * @author Christoph
 */
public class MotorVehicle extends Vehicle {
 
    //Instance Variables
    private int doors;
    private int maxSpeed;
    private String steering;
    
                    //Constructors
    //Default Constructor
    public MotorVehicle()
    {
        super();
        doors = 0;
        maxSpeed = 0;
        steering = "";
        
    }
    
    //Constructor with Parameters
    public MotorVehicle(int wheels, String colour, int seats, String model, String transmission, int doors, int maxSpeed, String steering)
    {
        super(wheels, colour, seats, model, transmission);
        this.doors = doors;
        this.maxSpeed = maxSpeed;
        this.steering = steering;
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
    
    //Method to set Steering
    public void setSteering(String steering)
    {
        this.steering = steering;
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
    
    //Method to return Steering
    public String getSteering()
    {
        return steering;
    }
    
    @Override
    public String toString()
    {
        return super.toString()  + "Doors: " + doors + "\nMax Speed: " + maxSpeed + "km/h\nSteering: " + steering + "\n";
    }
}