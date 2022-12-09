package timepackage;

/**
 *
 * @author Christoph Percival
 */
public class Clock {
    
    /*
    3 instance variables
        hr
        min
        sec
    2 constructors
    
    11 methods
        setTime()
        getHours()
        getMinutes()
        getSeconds()
        incrementHours()
        incrementMinutes()
        incrementSeconds()
        printTime()
        equals()
        makeCopy()
        getCopy()
        
        toString() default method supplied automatically by Java system, however you can override it
    */
	
	//Method override (toString())
	public String toString() {
		String time = "";
		
		if (hr < 10)
			time = "0";
		time += hr + ":";
		
		if (min < 10)
			time += "0";
		time += min + ":";
		
		if (sec < 10)
			time += "0";
		time += sec;
		
		return time;
	}
	
	//Instance Variables    
    private int hr; //store hours
    private int min; //store minutes
    private int sec; //store seconds
    
    							//Constructors
    //Constructor without Parameters (Default Constructor) to initialize instance variables
    public Clock() {
    	setTime(0, 0, 0);
    }
    
    //Constructor with Parameters to initialize instance variables
    public Clock(int hours, int minutes, int seconds) {
    	setTime(hours, minutes, seconds);
    }
    
    
    							//Methods
    //Method to Set Time
    public void setTime(int hours, int minutes, int seconds) {
    	
    	//Set Hours
    	if (hours >= 0 && hours < 24)
    		hr = hours;
    	else
    		hr = 0;
    	
    	//Set Minutes
    	if (minutes >= 0 && minutes < 60)
    		min = minutes;
    	else
    		min = 0;
    	
    	//Set Seconds
    	if (seconds >= 0 && seconds < 60)
    		sec = seconds;
    	else
    		sec = 0;
    }   
    
    //Method to Return Hours
    public int getHours() {
    	return hr;
    }
    
    //Method to Return Minutes
    public int getMinutes() {
    	return min;
    }
    
    //Method to Return Seconds
    public int getSeconds() {
    	return sec;
    }
    
    //Method to Increment Hours
    public void incrementHours() {
    	hr++;
    	
    	if (hr > 24)
    		hr = 0;
    }
    
    //Method to Increment Minutes
    public void incrementMinutes() {
    	min++;
    	
    	if (min > 59) {
    		min = 0;
    		incrementHours();
    	}
    }
    
    //Method to Increment Seconds
    public void incrementSeconds() {
    	sec++;
    	
    	if (sec > 59) {
    		sec = 0;
    		incrementMinutes();
    	}
    }
    
    //Method to Check if Two Times Are Equal
    public boolean equals(Clock otherClock) {
    	
    	return (hr == otherClock.hr && min == otherClock.min && sec == otherClock.sec);
    }
    
    //Method to Make Copy of Time
    public void makeCopy(Clock otherClock) {
    	hr = otherClock.hr;
    	min = otherClock.min;
    	sec = otherClock.sec;
    }
    
    //Method to Return The Copy of Time
    public Clock getCopy() {
    	Clock temp = new Clock();
    	
    	temp.hr = hr;
    	temp.min = min;
    	temp.sec = sec;
    	
    	return temp;
    }
    
    //Method To Print Time
    public void printTime() {
    	//Print Hours
    	if (hr < 10)
    		System.out.print("0");
    	System.out.print(hr + ":");
    	
    	//Print (Concatenate with) Minutes
    	if (min < 10)
    		System.out.print("0");
    	System.out.print(min + ":");
    	
    	//Print (Concatenate with) Seconds
    	if (sec < 10)
    		System.out.print("0");
    	System.out.print(sec);
    }
}