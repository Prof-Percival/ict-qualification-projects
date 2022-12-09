package viptransport;

/**
 *
 * @author Christoph
 */
public class Trip {
    
    //Instance Variables
    private String carId;
    private String destination;
    private double distance;
    private double fare;
    
                    //Constructors
    //Default Constructor
    public Trip()
    {
        carId = "";
        destination = "";
        distance = 0.0;
        fare = 0.0;
    }
    
    //Constructor with Parameters
    public Trip(String carId, String destination, double distance)
    {
        this.carId = carId;
        this.destination = destination;
        this.distance = distance;
        fare = 0.0;
        
        calculateTotalFare(distance); //Call Method to calculate Total Fare
    }
    
    
                    //Mutator Methods (Setters)
    //Method to set Car ID
    public void setCarId(String carId)
    {
        this.carId = carId;
    }
    
    //Method to set Destination
    public void setDestination(String destination)
    {
        this.destination = destination;
    }
    
    //Method to set Distance
    public void setDistance(double distance)
    {
        this.distance = distance;
        
        calculateTotalFare(distance); //Call Method to calculate Total Fare
    }
    
    
                    //Accessor Methods (Getters)
    //Method to return Car ID
    public String getCarId()
    {
        return carId;
    }
    
    //Method to return Destination
    public String getDestination()
    {
        return destination;
    }
    
    //Method to return Distance
    public double getDistance()
    {
        return distance;
    }
    
    //Method to return Total Fare
    public double getTotalFare()
    {
        return fare;
    }
    
    
                    //Other Methods
    //Method to Calculate Total Fare
    private void calculateTotalFare(double distance)
    {
        if (distance <= 20)
            fare = 50;
        else
            fare = 50 + ((distance - 20) * 2);
    }
    
    //Override toString() Method
    @Override
    public String toString()
    {
        return String.format("Car Id: %s%nDestination: %s%nDistance: %.1fKm%nTotal Fare Payable: R%.2f%n", carId, destination, distance, fare);
    }
    
}