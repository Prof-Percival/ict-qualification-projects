package hasarelationship;

/**
 *
 * @author Christoph
 */
public class Heart {
 
    //Instance Variables
    private double heartRate;
    
    
    //Default Constructor
    public Heart()
    {
        heartRate = 0.0;
    }
    
    //Constructor with Parameters
    public Heart(double heartRate)
    {
        this.heartRate = heartRate;
    }
    
    //Method to set Heart rate
    public void setHeartRate(double heartRate)
    {
        this.heartRate = heartRate;
    }
    
    //Method to Return Heart Rate
    public double getHeartRate()
    {
        return heartRate;
    }

    @Override
    public String toString()
    {
        return "Heart Rate: " + heartRate + "\n";
    }
    
}