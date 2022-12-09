package ch8exercise3;

/**
 *
 * @author Christoph
 */
public class Day {
    
    private int dayNo;
    private String day;
    
                    //Constructors
    //Default Constructor
    public Day()
    {
        dayNo = 1;
        day = "Monday";
    }
    
    //Constructor with parameter
    public Day(int day)
    {
        determineDay(day);
    }
    
    
                    //Methods
    //Overriding toString method
    public String toString()
    {
    	return ("Day: " + day);
    }
    //Method to Determine day of the week
    private void determineDay(int day)
    {
    	//Determining Day Number
    	if (day > 0)
    	{
    		if ((day %= 7) == 0)
    			this.dayNo = 7;
    		else
    			this.dayNo = day;
    		
    	}
    	else
    		this.dayNo = 1;
    	
    	//Determining day of the Week (Words)
    	switch (dayNo)
    	{
    		case 1 ->
    			this.day = "Monday";
    		case 2 ->
    			this.day = "Tuesday";
    		case 3 ->
    			this.day = "Wednesday";
    		case 4 ->
    			this.day = "Thursday";
    		case 5 ->
    			this.day = "Friday";
    		case 6 ->
    			this.day = "Saturday";
    		case 7 ->
    			this.day = "Sunday";    			
    	}    	
    }
    
    //Method to set day
    public void setDay(int day)
    {
    	determineDay(day);
    }
    
    //Method to Return day
    public String getDay()
    {
    	return day;
    }
    
    //Method to return next day
    public String getNextDay()
    {
    	determineDay(dayNo + 1);
    	return day;
    }
    
    //Method to return Previous day
    public String getPreviousDay()
    {
    	if (this.dayNo == 1)
    		determineDay(7);
    	else
    		determineDay(this.dayNo - 1);
    	return day;
    }
    
    public void addDaysToCurrentDays(int days)
    {
    	determineDay(dayNo + days);
    	printDay();
    	
    }
    
    //Method to print day
    public void printDay()
    {
    	System.out.println("Day: " + day);
    }
}